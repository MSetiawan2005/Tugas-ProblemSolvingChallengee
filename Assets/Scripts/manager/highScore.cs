using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour
{
    public Text HighestScore;

    // Start is called before the first frame update
    void Start()
    {
        HighestScore.text = $"HI-Score : { PlayerPrefs.GetInt("highestscore").ToString()}";
    }

}
