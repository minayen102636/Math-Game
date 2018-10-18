using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option3 : MonoBehaviour
{
    public GameObject realAnswerOption;
    public int Next3;

    public bool isCorrect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Next3 == 0)
        {
            GetComponent<TextMesh>().color = Color.white;
            Next3 = 1;
        }
    }
    private void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }


        else
        {
            GetComponent<TextMesh>().color = Color.red;

            Color32 color = new Color32(255, 160, 122, 255);//用橘色表示正確答案
            realAnswerOption.GetComponent<TextMesh>().color = new Color32(255, 160, 122, 255);//用橘色表示正確答案

        }

    }
}
