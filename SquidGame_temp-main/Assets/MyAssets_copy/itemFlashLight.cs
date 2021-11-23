using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemFlashLight : MonoBehaviour
{
    Transform playerPoint;
    Vector3 offset;
    public int light_num = 3;

    HandLightUI HandlightManager;

    void Start()
    {
        this.GetComponent<Light>().enabled = false;
        playerPoint = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerPoint.position;
        HandlightManager = GameObject.Find("Handlight").GetComponent<HandLightUI>();
    }

    void Update()
    {
        transform.position = playerPoint.position + offset;

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("남은 손전등 아이템 개수: " + light_num);


            if (light_num > 0 && light_num <= 3)
            {
                this.GetComponent<Light>().enabled = true;
                Debug.Log("손전등 비춤");
            }

            light_num -= 1;
            HandlightManager.SetHandlight(light_num);
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Light>().enabled = false;
        }
    }
}