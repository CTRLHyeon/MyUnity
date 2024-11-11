using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Movement : MonoBehaviour       //캐릭터의 움직임을 담당하는 코드
{
    public float movementSpeed;             //public 변수 movementSpeed 값을 직접 지정하여 이동속도 조정 가능

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
            x++;    //오른 키 입력 시 x = 1
        }
        if (Input.GetKey("left"))
        {
            x--;    //왼 키 입력 시 x = -1, 동시에 입력 시 x = 0
        }
        if (Input.GetKeyDown("up") && transform.position.y <= 0.2)  //윗 키 입력 시 (y가 0.2 이하 == 땅에 닿은 판정)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, 10);     //새 벡터 y = 10 부여
        }

        if (this.transform.position.x < -9.5)       // 벽에 닿을 시 움직이게 못하게 하는 코드
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
        rbody.velocity = new Vector2(x*movementSpeed, rbody.velocity.y);        //움직임을 속도로 부여하는 코드
    }
}
