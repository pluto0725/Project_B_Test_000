using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                 //���� HerbNum �����Ŀ� 1�� �Է� (public �߰�, �ν�â���� �����ֱ��ؼ� ����)

    void Start()
    {

        if(herbNum == 1)                    //���ǽ� herbNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��");    //Console.log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }
        else
        {
            Debug.Log("ü�� -50 ");         //Console.log â�� ������ ������ ��� �ش� ������
        }

    }

  
}
