using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;
using System;
using UnityEngine.UIElements;

public class LevelLoader : MonoBehaviour
{
    string _levelName;


    private void Start()
    {
        _levelName = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void LoadLevel()
    {
        StartCoroutine(LoadLevelAsync(_levelName));
    }

    private IEnumerator LoadLevelAsync(string levelName)
    {
        // Get the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Unload all scenes except PersistentScene
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name != "PersistentScene" && scene != currentScene)
            {
                AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(scene);
                while (!asyncUnload.isDone)
                {
                    yield return null;
                }
            }
        }

        // Load the new scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_levelName, LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
