using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//To add new levels, add scene names in the Button Manager script attached in the editor.
public class ButtonManager : MonoBehaviour
{
    public GameObject buttonPrefab;
    public string[] buttonTexts;
    void Start()
    {
        // Loop through each string in the array
        foreach (string text in buttonTexts)
        {
            // Instantiate a new button from the prefab
            GameObject newButton = Instantiate(buttonPrefab, gameObject.transform);

            // Get the Text component of the button and set its text to the current string
            TextMeshProUGUI buttonText = newButton.GetComponentInChildren<TextMeshProUGUI>();
            if (buttonText != null)
            {
                buttonText.text = text;
            }
            else
            {
                Debug.LogError("Button prefab does not contain a Text component!");
            }
        }
    }
}
