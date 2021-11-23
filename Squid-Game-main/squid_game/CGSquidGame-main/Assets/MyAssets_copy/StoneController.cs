using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //물체 던지는 함수
    public void Shoot(Vector3 speed)
    {   
        GetComponent<Rigidbody>().AddForce(speed);
    }
}