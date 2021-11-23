using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // HPObject = GameObject.Find("Hp").GetComponent<HpUI>();
    bool buttonOn;
    public GameObject TimerManager;
    TimerCountManager Tm;
    public void ClickButton()
    {
        if (!buttonOn)
        {
            Tm.SetTimerOn();
            buttonOn = true;
        }
        else
        {
            Tm.SetTimerStop();
            buttonOn = false;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        buttonOn = false;
        Tm = TimerManager.GetComponent<TimerCountManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
