using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //���� answer ����
        answer = 1 + 2;                 //answer�� 1+2 ���� ���� �Է�
        Debug.Log(answer);              //answer�� Debug.Log�� ��� ��Ų��.

        int n1 = 8;                     //���� n1 ���� �� �� 8�� �Է�
        int n2 = 9;                     //���� n2 ���� �� �� 9�� �Է�
        int answer2;                    //���� answer2 ����
        answer2 = n1 + n2;              //���� answer2�� n1 �� n2 ���� ���� �Է�
        Debug.Log(answer2);             //answer2�� Debug.Log�� ��� ��Ų��.

        int answer3 = 10;               //���� answer3 ���� �� �� 10�� �Է�
        answer3 += 5;                   //���� answer3�� +5 ���� �߰� (answer3 = answer3 + 5)
        Debug.Log(answer3);             //answer3�� Debug.Log�� ��� ��Ų��
        answer3++;                      //���� answer3�� +1 ���� �߰�
        Debug.Log(answer3);             //answer3�� Debug.Log�� ��� ��Ų��.

        string str = "Happy";           //���ڿ� str�� "Happy" �Է�
        string str2 = "birthday";       //���ڿ� str2�� "birthday" �Է�

        str += str2;                    //str = str + str2;
        Debug.Log(str);                 //str �� ���� Debug.Log�� ��� ��Ų��

        string message = str + answer3; //���ڿ� message�� �����ϰ� (String)�� str�� (int) �� answer3�� ���Ѵ�.
        Debug.Log(message);             //message ���� Debug,Log�� ��� ��Ų��.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
