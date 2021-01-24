using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public Player player;

    public GameObject TextPause;

    public GameObject HomeButton;

    public GameObject RestartButton;

    public GameObject RawImagePause;

    public GameObject ExitButton;

    private void Start() 
    {

    }
    public void UpButtonPressed()
    {
        player.UpButton = true;
    }

    public void DownButtonPressed()
    {
        player.DownButton = true;
    }

    public void RestartButtonControl()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.instance.ResetScore();
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        TextPause.SetActive(true);
        HomeButton.SetActive(true);
        RestartButton.SetActive(true);
        RawImagePause.SetActive(true);
        ExitButton.SetActive(true);


    }

    public void ExitButtonControl()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        TextPause.SetActive(false);
        HomeButton.SetActive(false);
        RestartButton.SetActive(false);
        RawImagePause.SetActive(false);
        ExitButton.SetActive(false);

    }

}
