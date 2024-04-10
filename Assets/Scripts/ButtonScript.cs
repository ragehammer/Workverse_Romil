using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int increaseAmount = 5;

    public void IncreaseScore()
    {
        EventManager.Instance.scoreEvent.RaiseScoreIncreaseEvent(increaseAmount);
    }
}
