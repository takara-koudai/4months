using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyenemy : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 3;
    public float jump = 5f;
    private bool Ground = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Ground)
        {
            Jump();
        }
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);

        Ground = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Ground = true;
            Debug.Log(Ground);
        }
    }

}
