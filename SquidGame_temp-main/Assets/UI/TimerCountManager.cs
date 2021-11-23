using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI사용
using UnityEngine.UI;



public class TimerCountManager : MonoBehaviour
{
    public Text[] clockText;
    public float time = 180.0f;
    private float countDown;
    bool timerOn;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
        countDown = time;
    }

    // Update is called once per frame

    // GameStart
    void Update()
    {
        // if(GameStart)

        if (Mathf.Floor(countDown) <= 0)
        {
            // 게임오버 호출

            GameManager.instance.GameOver();
        }
        else
        {
            countDown -= Time.deltaTime;
            clockText[0].text = ((int)countDown / 60 % 60).ToString();
            clockText[1].text = ((int)countDown % 60).ToString();
        }
    }

    public void SetTimerOn()
    {
        timerOn = true;
    }

    public void SetTimerStop()
    {
        timerOn = false;
    }

    public void SetTimerReset()
    {
        time = 0;
    }
}
