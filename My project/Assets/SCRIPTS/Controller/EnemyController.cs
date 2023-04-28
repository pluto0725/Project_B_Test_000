using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;                  //���� �ӵ� ����
    
    private Rigidbody rb;                       //Rigidbody ����
    private Transform player;                   //�÷��̾� ��ġ �������� ���� ����
    void Start()
    {
        rb = GetComponent<Rigidbody>();         //�����Ҷ� �ڱ� �ڽ��� Rigidbody �� �޾ƿ´�
        player = GameObject.FindGameObjectWithTag("Player").transform;      //Scene�ּ� Player Tag�� ���� ������Ʈ�� �����ͼ� Transform �� ����
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector3.Distance(player.position , transform.position) > 1.0f)                //Vector3.Distance <== �Ÿ��� �˷��ִ� �Լ�
        {
            Vector3 direction = (player.position - transform.position).normalized;      //�� ���͸� ���� Normlized �ϸ� ���� ���� �˷���
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //�÷��̾ ���ؼ� ������ speed �ӵ��� �̵�
        }
    }
}
