using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Movement : MonoBehaviour       //ĳ������ �������� ����ϴ� �ڵ�
{
    public float movementSpeed;             //public ���� movementSpeed ���� ���� �����Ͽ� �̵��ӵ� ���� ����

    float x;
    float y;
    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        x = 0;
        if (Input.GetKey("right"))  
        {
            x++;    //���� Ű �Է� �� x = 1
        }
        if (Input.GetKey("left"))
        {
            x--;    //�� Ű �Է� �� x = -1, ���ÿ� �Է� �� x = 0
        }
        if (Input.GetKeyDown("up") && transform.position.y <= 0.2)  //�� Ű �Է� �� (y�� 0.2 ���� == ���� ���� ����)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, 10);     //�� ���� y = 10 �ο�
        }

        if (this.transform.position.x < -9.5)       // ���� ���� �� �����̰� ���ϰ� �ϴ� �ڵ�
        {
            x++;
        }
        else if (this.transform.position.x > 9.5)
        {
            x--;
        }
    }

    private void FixedUpdate()
    {
        rbody.velocity = new Vector2(x*movementSpeed, rbody.velocity.y);        //�������� �ӵ��� �ο��ϴ� �ڵ�
    }
}
