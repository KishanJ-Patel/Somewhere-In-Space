using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMMainCamScript : MonoBehaviour
{
    public float Speed1;
    public float Speed2;
    public GameObject MainMenu;
    public GameObject GameTitle;

    private Vector3 StartPnt;
    private Vector3 SlowDownPnt;
    private Vector3 StopPnt;
    private int OperatorNum1;
    private int OperatorNum2;

    void Awake()
    {
        Time.timeScale = 1f;
        StartPnt = new Vector3(5f, 1.5f, -300f);
        SlowDownPnt = new Vector3(5f, 1.5f, -50f);
        StopPnt = new Vector3(5f, 1.5f, -7f);
    }

    void Start()
    {   
        transform.position = StartPnt;
        OperatorNum2 = 0;
    }

    void Update()
    {
        if (transform.position == StopPnt && OperatorNum2 == 0)
        {
            MainMenu.SetActive(true);
            OperatorNum2++;
        }
        else if(transform.position == SlowDownPnt)
        {
            GameTitle.SetActive(false);
            OperatorNum1 = 2;
        }
        else if(transform.position == StartPnt)
        {
            GameTitle.SetActive(true);
            OperatorNum1 = 1;
        }

        
        if(OperatorNum1 == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, StopPnt, Speed2 * Time.deltaTime);
        }
        else if(OperatorNum1 == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, SlowDownPnt, Speed1 * Time.deltaTime);
        }
    }
}
