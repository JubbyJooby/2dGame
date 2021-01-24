using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
  public void playGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Score.instance.ResetScore();
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Rules");
    }

    public void BackHome()
    {
        SceneManager.LoadScene("Start");
    }

    public void ShopEcommerce()
    {
        SceneManager.LoadScene("ShopEcommerce");
    }
}

