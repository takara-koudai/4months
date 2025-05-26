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

    void Start()
    {

         csvFile = Resources.Load<TextAsset>("NotNot1");
        if (csvFile == null)
        {
            Debug.LogError("CSVファイルが見つかりません");
            return;
        }

        StringReader reader = new StringReader(csvFile.text);
        List<string[]> csvData = new List<string[]>();

        while(reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }

        for(int i = 1; i< csvData.Count;i++)
        {
            string order = csvData[i][0];
            int answer = int.Parse(csvData[i][1]);
            if (order.Contains("左")) movementMap[order] = new Vector2(-9, 0);
            else if (order.Contains("右")) movementMap[order] = new Vector2(7, 1);
            else if (order.Contains("上")) movementMap[order] = new Vector2(0, 6);
            else movementMap[order] = new Vector2(0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
   

}
