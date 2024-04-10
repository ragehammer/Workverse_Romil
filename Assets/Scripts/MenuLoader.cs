using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public string _scene;
    private void Start()
    {
        SceneManager.LoadScene(_scene, LoadSceneMode.Additive);
    }
}
