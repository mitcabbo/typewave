using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    // Player selects MENU button
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Player selects QUIT button
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }

}
