using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMAllExtScript : MonoBehaviour
{
    public float CageRotSpd;
    public float SkyRotSpd;
    public GameObject Gun;
    public float GunRotSpd;

    private int MusicManager;

    void Start()
    {
        MusicManager = Random.Range(1, 51);
        
        if (MusicManager < 26) 
        {
            transform.Find("MenuMusic1").GetComponent<AudioSource>().enabled = true;
            transform.Find("MenuMusic1").GetComponent<AudioSource>().Play();
        }
        else if(MusicManager > 25)
        {
            transform.Find("MenuMusic2").GetComponent<AudioSource>().enabled = true;
            transform.Find("MenuMusic2").GetComponent<AudioSource>().Play();
        }
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * SkyRotSpd);
        transform.Rotate(xAngle: 0f, yAngle: CageRotSpd * Time.deltaTime, zAngle: 0f, relativeTo: Space.World);
        Gun.transform.Rotate(0f, GunRotSpd * Time.deltaTime, 0f, Space.World);
    }
}
