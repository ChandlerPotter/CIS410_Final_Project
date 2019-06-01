using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Level2()
    {
        SceneManager.LoadScene(8);
    }

    public void Level3()
    {
        SceneManager.LoadScene(9);
    }

    public void Level4()
    {
        SceneManager.LoadScene(12);
    }

    public void Level5()
    {
        SceneManager.LoadScene(11);
    }

    public void ChooseALevel()
    {
        SceneManager.LoadScene(7);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
