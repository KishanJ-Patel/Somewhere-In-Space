using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bul : MonoBehaviour
{  
    //public variables
    [Header("Float")]
    public float speed;

    [Header("Game Object")]
    public GameObject PlayerCam;
    public GameObject imptEfft;

    [Header("Do Not Touch")]
    public Vector3 hitPnt;
    public Vector3 hitNml;
    public bool RyHtSts;
    public GameObject imptEfftClone;

    void Start()
    {
        PlayerCam.GetComponent<PlayerCamScript>().BulSetter();   
    }

    void FixedUpdate()
    {
        transform.LookAt(worldPosition:hitPnt);
        transform.position = Vector3.MoveTowards(current: transform.position, target: hitPnt, maxDistanceDelta: speed);
        
        if (transform.position == hitPnt)
        {
            if (RyHtSts == true)
            {
                Destroy(obj: gameObject);
                imptEfftClone = Instantiate(original: imptEfft, position: hitPnt, rotation: Quaternion.LookRotation(hitNml));
                imptEfftClone.SetActive(value: true);
            }
            else if (RyHtSts == false)
            {   
                Destroy(obj: gameObject);
            }
        }
    }
}
