using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public ScoreData scoreData;

    private void OnEnable()
    {
        // Ensure EventManager.Instance is initialized
        if (EventManager.Instance != null && EventManager.Instance.scoreEvent != null)
        {
            scoreData.score = 0;
            EventManager.Instance.scoreEvent.onScoreIncrease += IncreaseScore;
        }
        else
        {
            Debug.LogError("EventManager or scoreEvent is not initialized!");
        }
    }

    private void OnDisable()
    {
        // Ensure EventManager.Instance is initialized
        if (EventManager.Instance != null && EventManager.Instance.scoreEvent != null)
        {
            EventManager.Instance.scoreEvent.onScoreIncrease -= IncreaseScore;
        }
        else
        {
            Debug.LogError("EventManager or scoreEvent is not initialized!");
        }
    }

    private void IncreaseScore(int increaseAmount)
    {
        scoreData.score += increaseAmount;
        Debug.Log("Score: " + scoreData.score);
    }
}
