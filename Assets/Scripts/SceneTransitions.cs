using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    public int sceneID;
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine((IEnumerator)LoadScene());
        }
    }

    IEnumerable LoadScene()
    {
        transitionAnim.SetTrigger("ANIM_End");
        transitionAnim.SetTrigger("StartTriangleAnimation"); // Start triangle animation
        yield return new WaitForSeconds(1.5f);
        transitionAnim.SetTrigger("EndTriangleAnimation"); // End triangle animation
        yield return new WaitForSeconds(1.5f); //wait 1.5 seconds before running next line of code
        SceneManager.LoadScene(sceneID);
    }
}
