using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    
    public GameObject StonePrefeb;  //game object 선ㅇ

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭하면
        {   
            GameObject stone = Instantiate(StonePrefeb) as GameObject; //게임 오브젝트 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray를 이용해 마우스 클릭점 구해서
            Vector3 shooting = ray.direction; //그 방향으로 shooting
            shooting = shooting.normalized * 2000; //던지는 힘 설정
            stone.GetComponent<StoneController>().Shoot(shooting);
        }
    }
}