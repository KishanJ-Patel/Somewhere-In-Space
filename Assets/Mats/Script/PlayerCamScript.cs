using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamScript : MonoBehaviour
{   
    //public variables
    [Header("Float")]
    public float range;

    [Header("Audio Clip")]
    public AudioClip BulSud;

    [Header("Transform")]
    public Transform BulSumPnt;
    public Transform MzlFlashSumPnt;

    [Header("Game Object")]
    public GameObject Bul;
    public GameObject MzlFlash;

    [Header("Do Not Touch")]
    public bool RyHtSts1;
    public RaycastHit hit;
    public GameObject BulClone;
    public GameObject MzlFlashClone;

    void FixedUpdate()
    {
        RyHtSts1 = Physics.Raycast(origin: transform.position, direction: transform.forward, out hit, maxDistance: range);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireButtonClick();
        }
        MzlFlashClone.transform.position = MzlFlashSumPnt.position; 
    }

    public void FireButtonClick()
    {
        MzlFlashClone = Instantiate(original: MzlFlash, position: MzlFlashSumPnt.position, rotation: MzlFlashSumPnt.rotation);
        MzlFlashClone.SetActive(true);
        Destroy(obj: MzlFlashClone, t: 0.2f);

        AudioSource.PlayClipAtPoint(clip: BulSud, position: BulSumPnt.position);

        if (RyHtSts1 == true)
        {
            BulClone = Instantiate(original: Bul, position: BulSumPnt.position, rotation: BulSumPnt.rotation);
            BulClone.SetActive(value: true);
        }

        else if (RyHtSts1 == false)
        {
            BulClone = Instantiate(original: Bul, position: BulSumPnt.position, rotation: BulSumPnt.rotation);
            BulClone.SetActive(value: true);
        }
    }

    public void BulSetter() 
    {   
        if (RyHtSts1 == true)
        {
            BulClone.GetComponent<Bul>().hitPnt = hit.point;
            BulClone.GetComponent<Bul>().hitNml = hit.normal;
            BulClone.GetComponent<Bul>().RyHtSts = true;
        }

        else if(RyHtSts1 == false)
        {
            BulClone.GetComponent<Bul>().hitPnt = transform.position + (transform.forward * range);
            BulClone.GetComponent<Bul>().RyHtSts = false;
        }

    }
}
