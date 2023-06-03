using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOutLyrScript : MonoBehaviour
{   
    //public vairables
    [Header("Line 1 Point 1")]
    public float L1P1x;
    public float L1P1y;
    public float L1P1z;

    [Header("Line 1 Point 2")]
    public float L1P2x;
    public float L1P2y;
    public float L1P2z;

    [Header("Line 1 Point 3")]
    public float L1P3x;
    public float L1P3y;
    public float L1P3z;

    [Header("Line 1 Point 4")]
    public float L1P4x;
    public float L1P4y;
    public float L1P4z;

    [Header("Line 1 Point 5")]
    public float L1P5x;
    public float L1P5y;
    public float L1P5z;

    [Header("Line 1 Point 6")]
    public float L1P6x;
    public float L1P6y;
    public float L1P6z;

    [Header("Line 2 Point 1")]
    public float L2P1x;
    public float L2P1y;
    public float L2P1z;

    [Header("Line 2 Point 2")]
    public float L2P2x;
    public float L2P2y;
    public float L2P2z;
    
    [Header("Line 2 Point 3")]
    public float L2P3x;
    public float L2P3y;
    public float L2P3z;

    [Header("Line 2 Point 4")]
    public float L2P4x;
    public float L2P4y;
    public float L2P4z;

    [Header("Line 2 Point 5")]
    public float L2P5x;
    public float L2P5y;
    public float L2P5z;

    [Header("Line 2 Point 6")]
    public float L2P6x;
    public float L2P6y;
    public float L2P6z;

    [Header("Line 3 Point 1")]
    public float L3P1x;
    public float L3P1y;
    public float L3P1z;

    [Header("Line 3 Point 2")]
    public float L3P2x;
    public float L3P2y;
    public float L3P2z;

    [Header("Line 3 Point 3")]
    public float L3P3x;
    public float L3P3y;
    public float L3P3z;

    [Header("Line 3 Point 4")]
    public float L3P4x;
    public float L3P4y;
    public float L3P4z;
   
    [Header("Line 3 Point 5")]
    public float L3P5x;
    public float L3P5y;
    public float L3P5z;
    
    [Header("Line 3 Point 6")]
    public float L3P6x;
    public float L3P6y;
    public float L3P6z;

    //private variables
    private int ColNum;
    private int LnNum;
    private int LnNumStop;
    private float speed;
    private Vector3 L1P1;
    private Vector3 L2P1;
    private Vector3 L3P1;
    private Vector3 L1P2;
    private Vector3 L2P2;
    private Vector3 L3P2;
    private Vector3 L1P3;
    private Vector3 L2P3;
    private Vector3 L3P3;
    private Vector3 L1P4;
    private Vector3 L2P4;
    private Vector3 L3P4;
    private Vector3 L1P5;
    private Vector3 L2P5;
    private Vector3 L3P5;
    private Vector3 L1P6;
    private Vector3 L2P6;
    private Vector3 L3P6;

    void Awake()
    {
        L1P1 = new Vector3(L1P1x, L1P1y, L1P1z);
        L2P1 = new Vector3(L2P1x, L2P1y, L2P1z);
        L3P1 = new Vector3(L3P1x, L3P1y, L3P1z);
        L1P2 = new Vector3(L1P2x, L1P2y, L1P2z);
        L2P2 = new Vector3(L2P2x, L2P2y, L2P2z);
        L3P2 = new Vector3(L3P2x, L3P2y, L3P2z);
        L1P3 = new Vector3(L1P3x, L1P3y, L1P3z);
        L2P3 = new Vector3(L2P3x, L2P3y, L2P3z);
        L3P3 = new Vector3(L3P3x, L3P3y, L3P3z);
        L1P4 = new Vector3(L1P4x, L1P4y, L1P4z);
        L2P4 = new Vector3(L2P4x, L2P4y, L2P4z);
        L3P4 = new Vector3(L3P4x, L3P4y, L3P4z);
        L1P5 = new Vector3(L1P5x, L1P5y, L1P5z);
        L2P5 = new Vector3(L2P5x, L2P5y, L2P5z);
        L3P5 = new Vector3(L3P5x, L3P5y, L3P5z);
        L1P6 = new Vector3(L1P6x, L1P6y, L1P6z);
        L2P6 = new Vector3(L2P6x, L2P6y, L2P6z);
        L3P6 = new Vector3(L3P6x, L3P6y, L3P6z);

        ColNum = 0;
        LnNumStop = 1;
    }

    void Update()
    {
        ColSetter();

        if (ColNum == 0)
        {
            if (LnNumStop == 1)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P1, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P1, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P1, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 1)
        {
            if (LnNumStop == 2)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P2, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P2, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P2, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 2)
        {
            if (LnNumStop == 3)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P3, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P3, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P3, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 3)
        {
            if (LnNumStop == 4)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P4, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P4, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P4, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 4)
        {
            if (LnNumStop == 5)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P5, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P5, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P5, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 5)
        {
            if (LnNumStop == 6)
            {
                LnSetter();
            }

            if (LnNum == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, L1P6, speed * Time.deltaTime);
            }

            else if (LnNum == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, L2P6, speed * Time.deltaTime);
            }

            else if (LnNum == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, L3P6, speed * Time.deltaTime);
            }
        }

        else if (ColNum == 6)
        {
            Destroy(gameObject);
        }
    }

    void ColSetter()
    {
        if (transform.position == L1P1 || transform.position == L2P1 || transform.position == L3P1)
        {
            ColNum = 1;
        }

        else if (transform.position == L1P2 || transform.position == L2P2 || transform.position == L3P2)
        {
            ColNum = 2;
        }

        else if (transform.position == L1P3 || transform.position == L2P3 || transform.position == L3P3)
        {
            ColNum = 3;
        }

        else if (transform.position == L1P4 || transform.position == L2P4 || transform.position == L3P4)
        {
            ColNum = 4;
        }

        else if (transform.position == L1P5 || transform.position == L2P5 || transform.position == L3P5)
        {
            ColNum = 5;
        }

        else if (transform.position == L1P6 || transform.position == L2P6 || transform.position == L3P6)
        {
            ColNum = 6;
        }
    }

    void LnSetter()
    {
        LnNum = Random.Range(1, 31);

        if (LnNum < 11)
        {
            LnNum = 1;
        }

        else if (LnNum > 10 && LnNum < 21)
        {
            LnNum = 2;
        }

        else
        {
            LnNum = 3;
        }
        speed = Random.Range(2f, 7f);
        LnNumStop++;
    }
}
