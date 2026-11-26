using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ManageFrontCurtain : MonoBehaviour
{
    private IEnumerator coroutine;
    private int nextSceneIndex = 1;

    public void OnClickButton(float seconds)
    {
        //Launch Coroutine
        Debug.Log ("Scene " + (nextSceneIndex + 1) + " of " + SceneManager.sceneCountInBuildSettings);
        nextSceneIndex += 1;
        if (nextSceneIndex > SceneManager.sceneCountInBuildSettings - 1)
        {
            nextSceneIndex = 0;
            return;
        }
        coroutine = WaitForTimer(seconds); //usually this would launch this, but for coroutines, need to add a new line to start the coroutine
        StartCoroutine(coroutine);
    }

    IEnumerator WaitForTimer(float seconds)
    {
        Debug.Log ("Time before: " + Time.time);
        Animator curtainAnimator = transform.GetComponent<Animator>();
        curtainAnimator.SetBool("ActivePatient", false);
        SceneManager.UnloadSceneAsync(nextSceneIndex-1);
        //set up patient scenes by scene index and replace below
        SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Additive);

        yield return new WaitForSeconds(seconds);
        Debug.Log ("Time after: " + Time.time);
        curtainAnimator.SetBool("ActivePatient", true);

        
    }
}
