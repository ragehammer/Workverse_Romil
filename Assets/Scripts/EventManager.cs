using UnityEngine;

public class EventManager : MonoBehaviour
{
    private static EventManager _instance;
    public static EventManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<EventManager>();
                if (_instance == null)
                {
                    GameObject eventManagerGameObject = new GameObject("EventManager");
                    _instance = eventManagerGameObject.AddComponent<EventManager>();
                }
            }
            return _instance;
        }
    }

    public ScoreEvent scoreEvent; // Reference to the score event

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Instantiate the score event
        scoreEvent = ScriptableObject.CreateInstance<ScoreEvent>();
    }
}
