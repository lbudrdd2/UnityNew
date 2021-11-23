using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    bool buttonOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickButton()
    {
        if (!buttonOn)
        {
            buttonOn = true;
        }
        else
        {
            buttonOn = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
