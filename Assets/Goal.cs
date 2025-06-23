using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private  int goalNum = 0;
    public static bool flag = true;
    public static bool flag2 = true;
    public static bool flag3 = true;
    public int Count = 0;
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
        
        Debug.Log(Count);
    }

    public int getGoalNum()
    {


        return goalNum;
    }
}
