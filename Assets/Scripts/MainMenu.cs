using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void QuitGame()
    {
        Debug.Log("Exitted the game");
        Application.Quit();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
