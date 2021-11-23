using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemFlashLight : MonoBehaviour
{
    Transform playerPoint;
    Vector3 offset;

    void Start()
    {
        this.GetComponent<Light>().enabled = false;
        playerPoint = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerPoint.position;
    }

    void Update()
    {
        transform.position = playerPoint.position + offset;

        if (Input.GetKey(KeyCode.L))
        {
            this.GetComponent<Light>().enabled = true;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.Space))
        { this.GetComponent<Light>().enabled = false; }
    }
}