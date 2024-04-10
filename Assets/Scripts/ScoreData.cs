using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScoreData", menuName = "Score Data")]
public class ScoreData : ScriptableObject
{
    public int score;
}
