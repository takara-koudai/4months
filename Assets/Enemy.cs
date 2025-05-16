using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject enemyPrefab;
    public float moveSpeed = 3;
    public int enemyCount = 5;
    public Vector2 spawnAreamin;
    public Vector2 spawnAreaMax;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-moveSpeed,rb.velocity.y);

        Debug.Log(rb.velocity);
    }



}
