using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour         // main �Լ�
{
    // �ʵ�
    // ���� ����
    // C# �Ľ�Į ǥ����� ī�� ǥ����� ����Ѵ�.
    int health; // <- �ʱ�ȭ�� ���� �ʾƵ� 0�̶�� ������ ����ȴ�.

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()       // ����Ƽ���� �������ִ� �Լ�
    {
        // ����
    }
}
