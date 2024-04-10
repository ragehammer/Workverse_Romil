using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public ScoreData scoreData;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        if (scoreText != null && scoreData != null)
        {
            // Update the text of the UI Text element with the current score value
            scoreText.text = "Score: " + scoreData.score.ToString();
        }
        else
        {
            Debug.LogWarning("ScoreData or scoreText is not assigned.");
        }
    }
}
