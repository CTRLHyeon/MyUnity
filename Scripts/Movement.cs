using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class Movement : MonoBehaviour
{
    public float movementSpeed;

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
            x++;
        }
        if (Input.GetKey("left"))
        {
            x--;
        }
        if (Input.GetKeyDown("up") && transform.position.y <= 0.2)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, 10);
        }

        if (this.transform.position.x < -9.5)
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
        rbody.velocity = new Vector2(x*movementSpeed, rbody.velocity.y);
    }
}
