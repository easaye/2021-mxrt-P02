using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //I used this website https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/ to reference
    //the timer codes, as it is a pretty useful website to understand and a straightforward method to create a efficient timer
    public TMP_Text timerText;
    public TMP_Text countdownText;

    public GameObject countdownPanel;

    private float timer = 60.0f;
    private float countdownTimer = 3.0f;
    private bool timerRunning  = false;
    private bool countDown = false;
    private bool gameStart = false;
    private float minutes = 0.0f;
    private float seconds = 0.0f;

    public static GameManager instance = null;
    private CheckShapes checkShapes;
    private RandomDrawing randomDrawing;
    // Start is called before the first frame update
    void Start()
    {
        countDown = true;
        timerText.enabled = false;
        checkShapes = GetComponent<CheckShapes>();
        randomDrawing = GetComponent<RandomDrawing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown)
        {
            timerRunning = true;
            
            if (timerRunning)
            {   
                DisplayTime(countdownTimer, countdownText);
                if (countdownTimer > 0)
                {
                    Debug.Log(timer);
                    countdownTimer -= Time.deltaTime;

                }
                else
                {
                    countdownTimer = 0;

                    timerRunning = false;
                    countDown = false;
                    gameStart = true;
                    randomDrawing.displayDrawing();
                    countdownPanel.SetActive(false);
                }
            }
        }

        if (gameStart)
        {
            timerRunning = true;
            timerText.enabled = true;
            checkShapes.checkShapes();
            if (timerRunning)
            {
                DisplayTime(timer, timerText);
                if (timer > 0)
                {
                    Debug.Log(timer);
                    timer -= Time.deltaTime;
                }
                else
                {
                    timer = 0;
                    timerRunning = false;
                    gameStart = false;
                    timerText.text = "00:00";
                }
            }
        }
    }

    void DisplayTime(float timeToDisplay, TMP_Text text)
    {

        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
