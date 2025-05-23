using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Command : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject command;
    public Text text;
    string[] texts = {"右にいけ","左に行け" };
    private string currentInstruction;

    void Start()
    {
        GenerateInstruction();
    }

    void GenerateInstruction()
    {

        currentInstruction = texts[Random.Range(0, texts.Length)];
        text.text = currentInstruction;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnPlayerMove(string direction)
    {

        bool isCorrect = (currentInstruction.Contains("Not") && !currentInstruction.Contains(direction) ||
            (!currentInstruction.Contains("NOT") && currentInstruction.Contains(direction)));

        if (isCorrect)
        {
            Debug.Log("正解");
            GenerateInstruction();
        }

        else
        {
            Debug.Log("ゲームオーバー");
        }

    }

}
