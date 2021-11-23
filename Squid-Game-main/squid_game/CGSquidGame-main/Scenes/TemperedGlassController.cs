using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class TemperedGlassController : MonoBehaviour
{

    [Space]
    public AudioClip tempered_sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //다른 rigidbody와 충돌할 경우 사운드 재생
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().clip = tempered_sound;
        GetComponent<AudioSource>().Play();
    }
}
