using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopGhostEquip : MonoBehaviour
{
    public GameObject Before25Score;
    
    public GameObject After25Score;

    public GameObject Before50Score;
    
    public GameObject After50Score;

    public GameObject Before100Score;
    
    public GameObject After100Score;

    public GameObject Before250Score;
    
    public GameObject After250Score;

    public Text highscoreDisplay;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        highscoreDisplay.text = Score.highscore.ToString();
        KeepScore();
    }

    public void KeepScore()
    {
        if (Score.highscore >= 25)
        {
            Before25Score.SetActive(false);
            After25Score.SetActive(true);
        }

        if (Score.highscore >= 50)
        {
            Before50Score.SetActive(false);
            After50Score.SetActive(true);
        }

        if (Score.highscore >= 100)
        {
            Before100Score.SetActive(false);
            After100Score.SetActive(true);
        }

        if (Score.highscore >= 250)
        {
            Before250Score.SetActive(false);
            After250Score.SetActive(true);
        }


    }
}
