using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;                                 //�߻� ���� ���� ����
    public GameObject Projectile;                                   //�߻�ü ������ ����

    public void FireProjectile()                                    //�߻� �Լ� ����
    {
        GameObject temp = (GameObject)Instantiate(Projectile);      //�߻�ü �������� ���� ��Ű�� temp�� �Է�  
                                                                    //Instantiate �Լ��� GameObject , �������� ���� ��Ų��.
        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10f);             //�߻�ü ������� 10���Ŀ� �������.

    }
}
    
