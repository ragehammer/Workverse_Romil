using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewScoreEvent", menuName = "Events/Score Event")]
public class ScoreEvent : ScriptableObject
{
    public UnityAction<int> onScoreIncrease;

    public void RaiseScoreIncreaseEvent(int increaseAmount)
    {
        onScoreIncrease?.Invoke(increaseAmount);
    }
}
