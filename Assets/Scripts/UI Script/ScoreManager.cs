using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //Score
    private static int highScore;

    private static ScoreManager _instance = null;
    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();
            }
            return _instance;
        }
    }

    private int currentScore;


    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }


    private void Start()
    {
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void IncrementCurrentScore(int num)
    {
        currentScore += num;
    }

    public void SetHighScore()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;
        }
           
    }


}
