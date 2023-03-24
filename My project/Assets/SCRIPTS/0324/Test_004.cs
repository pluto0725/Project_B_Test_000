using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;
    
    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }
        if(Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }

        if (hp <= 50)
        {
            //Debug.Log("���� !");
            textUI.text = "���� !";
        }
        else if (hp >= 200)
        {
            //Debug.Log("���� !");
            textUI.text = " ���� !";
        }
        else
        {
            //Debug.Log("��� !");
            textUI.text = "��� !";
        }

        hpTextUI.text = "HP : " + hp.ToString();
    }
}
