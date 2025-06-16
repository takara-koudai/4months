using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Command : MonoBehaviour
{

    //Start is called before the first frame update

    Dictionary<string, Vector2> movementMap = new Dictionary<string, Vector2>();
    private  TextAsset csvFile;
    [SerializeField]
    private  Text orderText;
    bool isColliding = false;
    bool isColliding2 = true;
    bool isColliding3 = true;
    List<string[]> csvData = new List<string[]>();
    public class QA
    {
        public string order;
        public string answer;

        public QA(string order, string answer)
        {
            this.order = order;
            this.answer = answer;
        }
    }


    void Start()
    {

        csvFile = Resources.Load<TextAsset>("NotNot1");
        if (csvFile == null)
        {
            Debug.LogError("CSVÉtÉ@ÉCÉãÇ™å©Ç¬Ç©ÇËÇ‹ÇπÇÒ");
            return;
        }

        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }


        string[] lines = csvFile.text.Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
        //SetOrder();
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Timer.deadcount);
        if (isColliding == false && Timer.time == 5)
        {
            SetOrder();
            Timer.deadcount += 1;
        }
        if (isColliding2 == false && Timer.time == 5)
        {
            SetOrder();
            Timer.deadcount += 1;
        }
        if (isColliding3 == false && Timer.time == 5)
        {
            SetOrder();
            Timer.deadcount += 1;
        }

    }

    private void SetOrder()
    {
        int randomIndex = Random.Range(1, csvData.Count - 1);
        string text = csvData[randomIndex][0];
        orderText.text = text;

        Debug.Log(randomIndex);
        
    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {    //ê≥â
        if (collsion.gameObject.CompareTag("Goal"))
        {
            transform.position = player.teleport;
            Timer.time = 5f;
            SetOrder();
        }
        if (collsion.gameObject.CompareTag("Goal2"))
        {
            transform.position = player.teleport;
            Timer.time = 5f;
            SetOrder();
        }
        if (collsion.gameObject.CompareTag("Goal3"))
        {
            transform.position = player.teleport;
            Timer.time = 5f;
            SetOrder();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            isColliding = true;
        }
        if (collision.gameObject.CompareTag("Goal2"))
        {
            isColliding2 = true;
        }
        if (collision.gameObject.CompareTag("Goal3"))
        {
            isColliding3 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isColliding = false;
        isColliding2 = false;
        isColliding3 = false;
    }

}
