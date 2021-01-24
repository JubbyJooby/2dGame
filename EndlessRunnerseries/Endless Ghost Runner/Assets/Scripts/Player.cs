using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    public SoundOnOrOff Sound;

    public bool UpButton;

    public bool DownButton;

    private Vector2 targetPos;

    public int health;

    public Animator camAnim;
    public Text healthDisplay;

    public GameObject spawner;

    public GameObject HomeRestart;
    public GameObject restartDisplay;

    public GameObject HighScoreText;
    
    public GameObject HighScoreDisplay;

    private GameObject[] clone;

    static Color color = Color.white;
    
    static SpriteRenderer ghostSprite;


    private void Start() 
    {
        Score.instance.ResetScore();
        ghostSprite = GetComponent<SpriteRenderer>();

    }
    
    private void Update()
    {
        ghostSprite.color = color;
        healthDisplay.text = health.ToString();
        if (health <= 0) {
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            HighScoreDisplay.SetActive(true);
            HomeRestart.SetActive(true);
            HighScoreText.SetActive(true);
            Destroy(gameObject);
            clone = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject item in clone)
            {
                Destroy(item);
            }

        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {

            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }

        if (UpButton == true && transform.position.y < maxY) {
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
            UpButton = false;
        } else if (DownButton == true && transform.position.y > minY) {

            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
            DownButton = false;
        }
    }

    public void SetColor(Color newColor)
    {
        color = newColor;
        //ghostSprite.color = color;
    }
}
