using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour         // main 함수
{
    // 필드
    // 변수 선언
    // C# 파스칼 표기법과 카멜 표기법을 사용한다.
    int health; // <- 초기화를 하지 않아도 0이라는 값으로 저장된다.

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()       // 유니티에서 제공해주는 함수
    {
        // 로직
    }
}
