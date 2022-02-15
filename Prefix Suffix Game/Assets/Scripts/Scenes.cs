using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void LoadScene(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}