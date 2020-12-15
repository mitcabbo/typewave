using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _score;
    public Text scoreText;


public void AddScore()
        {
            _score++;
            scoreText.text = _score.ToString();
        }
    
}
