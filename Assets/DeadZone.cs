using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if (collsion.gameObject.CompareTag("Dead"))
        {
           transform.position =  player.teleport;
            Timer.deadcount++;
        }


    }
}
