using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    
    public Rigidbody2D rb;

    float moveSpeed = 4f;
    float jampspeed = 8f;

    private bool isJamp;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //���ɓ���
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

        //�E�ɓ���
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        //�W�����v
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jampspeed);
            isJamp = true;
        }


    }
}
