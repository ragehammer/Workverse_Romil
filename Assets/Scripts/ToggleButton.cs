using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    public GameObject levelSelectionButtons;
    // dotween stuff
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;
    public void Toggle()
    {
        if (levelSelectionButtons != null) 
        {
            if (levelSelectionButtons.activeSelf == false)
            {
                ScaleUp();
                levelSelectionButtons.SetActive(true);
                PanelFadeIn();
            }
            else if (levelSelectionButtons.activeSelf == true)
            {
                ScaleUp();
                levelSelectionButtons.SetActive(false);
            }
        }
        else
        {
            Debug.LogWarning("Buttons not attached");
        }
    }
    public void PanelFadeIn()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.DOFade(1, fadeTime);
    }

    Vector3 ogScale;
    Vector3 scaleTo;

    public void ScaleUp()
    {
        StartCoroutine(ScaleCoroutine());
    }

    private IEnumerator ScaleCoroutine()
    {
        // Store the original scale
        ogScale = transform.localScale;
        // Calculate the scale to which the object will be scaled
        scaleTo = ogScale * 1.2f;

        // Scale up with animation
        transform.DOScale(scaleTo, fadeTime).SetEase(Ease.InOutSine);

        // Wait for fadeTime seconds
        yield return new WaitForSeconds(fadeTime);

        // Scale down with animation after waiting
        transform.DOScale(ogScale, fadeTime).SetEase(Ease.InOutSine);
    }
}
