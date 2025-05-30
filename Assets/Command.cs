using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Command : MonoBehaviour
{

    //Start is called before the first frame update
    
    Dictionary<string, Vector2> movementMap = new Dictionary<string, Vector2>();
    private TextAsset csvFile;
    [SerializeField]
    private Text orderText;

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
            Debug.LogError("CSVƒtƒ@ƒCƒ‹‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ");
            return;
        }

        StringReader reader = new StringReader(csvFile.text);

        while(reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }


        string[] lines = csvFile.text.Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
        Debug.Log(csvData); 
        Debug.Log(orderText);
        SetOrder();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void SetOrder()
    {
        if (csvData.Count == 9)
        {

        }
        int randomIndex = Random.Range(1, csvData.Count - 1);
        string text = csvData[randomIndex][0];
        orderText.text = text;
    }
}
