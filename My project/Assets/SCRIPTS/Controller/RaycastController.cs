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
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);                    //화면에서의 2차원 마우스 좌표를 입력해서 3D 카메라에서 Ray를 만드는 함수

            RaycastHit hit;
            
            if(Physics.Raycast(cast, out hit))                                               //Ray 가 충돌 감지된것을 hit 로 돌려준다
            {
                if (hit.collider.tag == "Ground")                                            //Tag가 땅일 때
                {
                    GameObject temp = (GameObject)Instantiate(Monster);                      //몬스터 프리팹을 생성 하겠다.
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);     //Ray 충돌 위치에
                }

                Debug.Log(hit.collider.name);                                               //오브젝트 이름을 출력
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                    //Ray 쏴지는것을 가시적으로 보여준다
            }
        }
    }
}
