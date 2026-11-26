using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void OnNextClick()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
    }

    public void OnBackClick()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene > 0)
        {
            SceneManager.LoadScene(currentScene - 1);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}