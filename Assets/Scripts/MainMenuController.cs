using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject tutorialPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu Utama");
    }

    public void Close()
    {
        tutorialPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
