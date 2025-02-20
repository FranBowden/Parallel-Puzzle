using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //if user presses R
        {
            RestartScene(); //restart
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload the same scene
    }
}
