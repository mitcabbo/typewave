﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;

    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            // Show Game Over Scene
            GameOver();
        }
    }

    void GameOver ()
    {
        SceneManager.LoadScene("GameOver");
    }
    
}
