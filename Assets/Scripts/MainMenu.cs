using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);

    }
    public void ExitGame()
    {
        Application.Quit();

    }
}
