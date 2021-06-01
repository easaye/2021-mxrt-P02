using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;

    public static Score instance = null;

    private int correctMultiplier = 100;
    private int wrongDeduct = 50;
    private int scoreWCorrect;
    private int scoreWWrong;
    private int finalScore;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0000";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + finalScore;
    }

    public void AddScore()
    {
        scoreWCorrect = 1 * correctMultiplier;
        finalScore += scoreWCorrect;
    }

    public void DeductScore()
    {
        scoreWWrong = 1 * wrongDeduct;
        finalScore -= scoreWWrong;
    }
}
