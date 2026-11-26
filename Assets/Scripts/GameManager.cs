using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int nextSceneIndex = 1; //increases scene index to go to the next scene
    private int sceneCount;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Init();
        }

        DontDestroyOnLoad(this);
        sceneCount = SceneManager.sceneCountInBuildSettings;
    }

    void Init()
    {
        SceneManager.LoadScene(1); //loading scene 1 by index
    }

    /*public void OnNextClick()
    {
        Debug.Log ("Scene " + (nextSceneIndex + 1) + " of " + SceneManager.sceneCountInBuildSettings);
        nextSceneIndex += 1;
        if (nextSceneIndex > sceneCount - 1)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnBackClick()
    {
        nextSceneIndex -= 1;
        if (nextSceneIndex < 0)
        {
            nextSceneIndex = sceneCount - 1;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }*/
}
