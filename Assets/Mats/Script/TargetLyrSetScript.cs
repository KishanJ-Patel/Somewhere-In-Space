using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLyrSetScript : MonoBehaviour
{
    //public variables
    [Header("Float")]
    public float speed;

    [Header("Game Object")]
    public GameObject SubSphere;
    public GameObject TDEgreen;
    public GameObject TDEred;
    public GameObject TDEyellow;

    //private variables
    private int LyrSetNum;
    private GameObject TDEgreenClone;
    private GameObject TDEredClone;
    
    void Start()
    {
        LyrSetNum = Random.Range(1, 11);

        if (LyrSetNum < 7)
        {
            gameObject.GetComponent<TargetInLyrScript>().enabled = true;
        }

        else
        {
            gameObject.GetComponent<TargetOutLyrScript>().enabled = true;
        }
    }

    void Update()
    {
        SubSphere.transform.RotateAround(point: transform.position, axis: Vector3.right, angle: speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            if (gameObject.CompareTag("Target_Yellow"))
            {   
                if (TDEyellow.GetComponent<ParticleSystem>().isPlaying)
                {   
                    Destroy(gameObject);
                }
                else if (!TDEyellow.GetComponent<ParticleSystem>().isPlaying)
                {   
                    TDEyellow.GetComponent<ParticleSystem>().Play(true);
                    TDEyellow.GetComponent<AudioSource>().enabled = true;
                    Destroy(gameObject);
                }
            }
            else if (gameObject.CompareTag("Target_Green"))
            {   
                TDEgreenClone = Instantiate(TDEgreen, transform.position, TDEgreen.transform.rotation);
                TDEgreenClone.SetActive(true);
                Destroy(TDEgreenClone, 2.5f);
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Target_Red"))
            {
                TDEredClone = Instantiate(TDEred, transform.position, TDEred.transform.rotation);
                TDEredClone.SetActive(true);
                Destroy(TDEredClone, 2.5f);
                Destroy(gameObject);
            }
        }
    }

}
