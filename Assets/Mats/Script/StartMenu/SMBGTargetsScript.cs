using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMBGTargetsScript : MonoBehaviour
{
    private float Speed;
    private float Timer;
    private int DirecMngNum;

    public GameObject Subsphere;
    public float SubSphSpd;

    void Start()
    {
        DirecMngNum = Random.Range(1, 11);
        if (DirecMngNum > 6)
        {
            Speed = Random.Range(20f, 70f);
        }
        else
        {
            Speed = Random.Range(-20f, -70f);
        }
    }

    void Update()
    {
        Timer += Time.deltaTime;
        Subsphere.transform.RotateAround(transform.position, Vector3.right, SubSphSpd * Time.deltaTime);
        if (DirecMngNum > 6)
        {
            if (Timer >= 7f)
            {
                Speed = Random.Range(20f, 70f);
                Timer -= 7f;
            }
            transform.RotateAround(new Vector3(5f, 1.5f, 0f), Vector3.up, Speed * Time.deltaTime);
        }
        else
        {
            if (Timer >= 7f)
            {
                Speed = Random.Range(-20f, -70f);
                Timer -= 7f;
            }
            transform.RotateAround(new Vector3(5f, 1.5f, 0f), Vector3.up, Speed * Time.deltaTime);
        }
    }
}
