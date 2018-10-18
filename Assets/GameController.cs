using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int answer;
    public string ramdonOperator;

    public int a;
    public int b;
  
    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public GameObject realAnswerOption;

    public int Next;
    public GameObject NextObject;

    void Start()
    {
        GenerateQuestion();
    }

   
    void Update()
    {

        if (Next == 0)
        {
            GenerateQuestion();
            Next = 1;
        }

    }

    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);

        int operatorNumber = Random.Range(0, 4);

        if (operatorNumber == 0)
        {
            //分流一：operator Number為0，進行加法
            ramdonOperator = "+";
            answer = a + b;
        }

        else if (operatorNumber == 1)
        {
            //分流二：operator Number為1，進行減法
            ramdonOperator = "-";
            answer = a - b;
        }

        else
        {
            //分流三：operator Number為2，進行乘法
            ramdonOperator = "*";
            answer = a * b;
        }

        int option = Random.Range(0, 3);

        if (option == 0)
        {
            realAnswerOption = option1;
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = true; 
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option2.GetComponent<Option2>().isCorrect = false;
            option2.GetComponent<Option2>().realAnswerOption = option1;

            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 2)).ToString();
            option3.GetComponent<Option3>().isCorrect = false;
            option3.GetComponent<Option3>().realAnswerOption = option1; 
        }
        else if (option == 1)
        {
            realAnswerOption = option2;
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option1.GetComponent<Option>().realAnswerOption = option2; 
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<Option2>().isCorrect = true;

            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 2)).ToString();
            option3.GetComponent<Option3>().isCorrect = false;
            option3.GetComponent<Option3>().realAnswerOption = option2;

        }

        else 
        {
            realAnswerOption = option3;
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option1.GetComponent<Option>().realAnswerOption = option3;

            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 2)).ToString();
            option2.GetComponent<Option2>().isCorrect = false;
            option2.GetComponent<Option2>().realAnswerOption = option3;

            option3.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<Option3>().isCorrect = true;

        }
        question.GetComponent<TextMesh>().text = a + " " + ramdonOperator + " " + b + " = ?";
    }

}

