using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void PlayGameCPU()
    {
        SceneManager.LoadScene("Story");
    }


    public void QuitGame()
    {
        Application.Quit();
    }


    public void Next()
    {
        SceneManager.LoadScene("IPJ");
    }


    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
