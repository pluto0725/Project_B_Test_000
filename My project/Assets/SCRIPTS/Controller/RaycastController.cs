using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject Monster;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);                    //ȭ�鿡���� 2���� ���콺 ��ǥ�� �Է��ؼ� 3D ī�޶󿡼� Ray�� ����� �Լ�

            RaycastHit hit;
            
            if(Physics.Raycast(cast, out hit))                                               //Ray �� �浹 �����Ȱ��� hit �� �����ش�
            {
                if (hit.collider.tag == "Ground")                                            //Tag�� ���� ��
                {
                    GameObject temp = (GameObject)Instantiate(Monster);                      //���� �������� ���� �ϰڴ�.
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);     //Ray �浹 ��ġ��
                }

                Debug.Log(hit.collider.name);                                               //������Ʈ �̸��� ���
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                    //Ray �����°��� ���������� �����ش�
            }
        }
    }
}
