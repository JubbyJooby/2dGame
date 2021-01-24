using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static Score instance;
    public int score;
    public static int highscore;
    public Text scoreDisplay;
    public Text highscoreDisplay;

    private void Start() 
    {
        instance = this;    
    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        highscoreDisplay.text = highscore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddScore();
        Destroy(other.gameObject);
    }

    private void AddScore()
    {
        score++;
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (score > highscore)
        {
            highscore = score;
        }
    }

    public void ResetScore()
    {
        score = 0; 
    }
}
