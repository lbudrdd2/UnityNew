using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLightGlass : MonoBehaviour
{
    public GameObject player;
    public Material unbreakable;
    public Material window;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        window = Resources.Load("Window", typeof(Material)) as Material;
        unbreakable = Resources.Load("Unbreakable glass", typeof(Material)) as Material;
        GetComponent<Renderer>().material = window;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Renderer>().material = unbreakable;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.Space))
        { GetComponent<Renderer>().material = window; }*/
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && Input.GetKey(KeyCode.L))
        {
            GetComponent<Renderer>().material = unbreakable;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
           Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
           Input.GetKey(KeyCode.Space))
        { GetComponent<Renderer>().material = window; }
    }
}
