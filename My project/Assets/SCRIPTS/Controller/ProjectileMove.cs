using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;                     //발사체 방향성 선언

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }

    public BULLETTYPE bulletType = BULLETTYPE.PLAYER;

    private void FixedUpdate()                          //이동 관련 함수
    {
        float moveAmount = 3 * Time.fixedDeltaTime;             //발사체 이동 속도
        transform.Translate(launchDirection * moveAmount);      //해당방향으로 이동

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);                   //충돌이 일어날때 이름을 가져온다

        if (collision.gameObject.name == "wall")
        {
            GameObject temp = this.gameObject;                      //나 자신을 가져와서 temp에 입력한다.
            Destroy(temp);                                      //곧바로 파괴한다
        }

        if (collision.gameObject.name == "Monster")
        {
            GameObject temp = this.gameObject;                      //나 자신을 가져와서 temp에 입력한다.
            Destroy(temp);

        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            GameObject temp = this.gameObject;                      //나 자신을 가져와서 temp에 입력한다.
            Destroy(temp);                                      //곧바로 파괴한다
        }


        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)               //몬스터와 충돌이 일어났을 때
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }

        if (other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            //other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }
}
