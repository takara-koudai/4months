using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public static float time = 5f;
    public float time2 = 1f;
    public TextMeshProUGUI timertext;
    public static bool flag = false;
    public static float deadcount = 0;
    void Start()
    {
        flag = false;
        timertext.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0 && flag == false)
        {
            time -= Time.deltaTime;
            timertext.text = Mathf.Ceil(time).ToString();
        }
        else
        {
            timertext.text = "time up!!";
            flag = true;
        }
        if (time <= 0)
        {
            time2 -= Time.deltaTime;
            if (time2 <= 0)
            {
                timertext.gameObject.SetActive(false);
            }
        }

        if(time >= 5)
        {
            deadcount += 1;
        }
    }
}
