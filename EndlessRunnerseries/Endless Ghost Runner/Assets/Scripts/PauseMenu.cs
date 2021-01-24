using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject TextPause;

    public GameObject HomeButton;

    public GameObject RestartButton;

    public GameObject RawImagePause;

    public GameObject ExitButton;
    // Start is called before the first frame update
    void Start()
    {
        TextPause.SetActive(false);
        HomeButton.SetActive(false);
        RestartButton.SetActive(false);
        RawImagePause.SetActive(false);
        ExitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
