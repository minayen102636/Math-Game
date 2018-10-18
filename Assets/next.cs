using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject Core;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public int Next4;

    void Start()
    {
  
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        Core.GetComponent<GameController>().Next = 0;
       
        option1.GetComponent<Option>().Next1 = 0;
        option2.GetComponent<Option2>().Next2 = 0;
        option3.GetComponent<Option3>().Next3 = 0;

    }
}
