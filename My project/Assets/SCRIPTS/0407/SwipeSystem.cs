using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    public Vector2 initialPos;
    public GameObject Character;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finalpos)
    {
        float disX = Mathf.Abs(initialPos.x - finalpos.x);
        float disY = Mathf.Abs(initialPos.y - finalpos.y);

        if (disX > 0 || disY > 0)
        {
            if(disX > disY)
            {
                if(initialPos.x > finalpos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
            else
            {
                if (initialPos.y > finalpos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }

    }
}
