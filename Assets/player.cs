using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    float moveSpeed = 4f;
    float jampspeed = 6f;
    public static Vector2 teleport;
    // private bool isJamp;
    public string nextSceneName;
    public bool isGoal = false;
    public int goalNum = -1;

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

        //‰E‚É“®‚­
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        //ƒWƒƒƒ“ƒv
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jampspeed);

            //isJamp = true;
        }

        if(Timer.time == 5f)
        {
            transform.position = teleport;
        }

        if(Timer.deadcount>=12)
        {
            SceneManager.LoadScene(nextSceneName);
        }

    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.tag == "Goal")
        {
            Goal goal = collsion.gameObject.GetComponent<Goal>();
            goalNum = goal.getGoalNum();
            Debug.Log(goalNum);
            transform.position = teleport;
            Timer.time = 5f;
            isGoal = true;
        }

        if (collsion.gameObject.CompareTag("Dead"))
        {
            transform.position = teleport;
            Timer.deadcount++;
            Timer.time = 5f;

        }

    }

  

}
