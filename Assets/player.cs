using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool flag = false;
    float moveSpeed = 4f;
    float jampspeed = 8f;
    public Vector2 teleport;
   // private bool isJamp;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

        //右に動く
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        //ジャンプ
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jampspeed);

            //isJamp = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.CompareTag("Goal"))
        {
            Debug.Log("衝突しました");
            transform.position = teleport;

        }
        if (collsion.gameObject.CompareTag("Goal2"))
        {
            Debug.Log("衝突しました");
            transform.position = teleport;
        }
        if (collsion.gameObject.CompareTag("Goal3"))
        {
            Debug.Log("衝突しました");
            transform.position = teleport;
        }
    }

}
