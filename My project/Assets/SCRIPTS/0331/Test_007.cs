using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
   void SayHello()                                      //�μ��� ��ȯ���� ���� �޼���
    {
        Debug.Log("==================");
        Debug.Log("Hello");
        Debug.Log("==================");
    }

    void CallName(string name)                          //�μ��� �ִ� �޼���
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a, int b)                                //�μ��� ��ȯ���� �ִ� �޼���
    {
        int c = a + b;
        return c;                                       //int�� �Լ��� �����߱� ������ return�� int ���� ��
    }

    void Start()
    {
        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        int answer;                                     //���� answer �� �����ߴ�.
        answer = Add(2, 3);                             //�޼��带 ȣ���ؼ� 2,3�� ���� �Է����ش�. �׸��� return ���� answer �� �������ش�.
        Debug.Log(answer);
        Debug.Log(Add(7, 9));                           //�Լ��� ������ ���� �ʰ� Debug.Log�� �μ��� ��� �Ҽ� �ִ�.
    }

}
