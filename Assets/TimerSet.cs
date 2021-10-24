using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSet : MonoBehaviour
{

    public Text TextTimer;
    public float waktu = 100;

    public bool gameAktif = true;
    public GameObject gameover;
    void SetText()
    {
        int Menit = Mathf.FloorToInt(waktu / 60);
        int Detik = Mathf.FloorToInt(waktu % 60);

        TextTimer.text = Menit.ToString("00") +":"+ Detik.ToString("00");
    }

    float s;

    private void Update()
    {
        if (gameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                waktu--;
                s = 0;
            }
        }
      
        if(gameAktif && waktu <= 0)
        {
            Debug.Log("game over");
            gameover.SetActive(true);
            gameAktif = false;
        }
        SetText();

        
    }
}
