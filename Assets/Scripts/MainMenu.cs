using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject controlMenu;
    public GameObject mainMenu;
    public bool isControl;
    // Start is called before the first frame update
    void Start()
    {
        controlMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ControlMenu()
    {
        controlMenu.SetActive(true);
        mainMenu.SetActive(false);
        isControl = true;
    }



    public void GoBack()
    {
        controlMenu.SetActive(false);
        mainMenu.SetActive(true);
        isControl = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
