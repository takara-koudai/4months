using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Command2 : MonoBehaviour
{
    // Start is called before the first frame update

    private TextAsset csvFile;
    [SerializeField]
    private Text orderText;
    List<string[]> csvData = new List<string[]>();
    Player player = null;
    private int currentGoalNum = -1;
    private int Correct = 0;
    private int Notcorrect = 0;

    bool isColliding = false;
    bool isColliding2 = true;
    bool isColliding3 = true;
    public string nextSceneName;
    public string nextSceneName2;
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
        csvFile = Resources.Load<TextAsset>("NotNot2");
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

        player= GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (player.isGoal)
        {
            if(player.goalNum == csvData.Count)
            {
                Correct++;
                Debug.Log(Correct);
                SetOrder();
                player.isGoal = false;
            }

            else if(player.goalNum != csvData.Count)
            {
                Notcorrect += 1;
                Debug.Log(Notcorrect);
                player.isGoal = false;
                SetOrder();
            }

        }
        if(Correct == 5)
        {
            SceneManager.LoadScene(nextSceneName);

        }
        if(Notcorrect == 5)
        {
            SceneManager.LoadScene(nextSceneName2);
        }

    }

    public void SetOrder()
    {
        int randomIndex = Random.Range(1, csvData.Count - 1);
        string text = csvData[randomIndex][0];
        orderText.text = text;
        // Debug.Log(randomIndex);
    }
    //private void OnCollisionEnter2D(Collision2D collsion)
    //{
    //    //ê≥â

    //    if (collsion.gameObject.CompareTag("Goal"))
    //    {
    //        transform.position = Player.teleport;
    //        Timer.time = 5f;
    //        SetOrder();
    //        Goal goal = collsion.gameObject.GetComponent<Goal>();
    //        int coalNum = goal.getGoalNum();
    //        Command command = new Command();
    //        command = command.gameObject.GetComponent<Command>();
    //        coalNum = goal.getGoalNum();
    //    }

    //    if (collsion.gameObject.CompareTag("Goal"))
    //    {
    //        transform.position = Player.teleport;
    //        Timer.time = 5f;
    //        SetOrder();
    //    }
    //    if (collsion.gameObject.CompareTag("Goal"))
    //    {
    //        transform.position = Player.teleport;
    //        Timer.time = 5f;
    //        SetOrder();
    //    }

    //}
}
