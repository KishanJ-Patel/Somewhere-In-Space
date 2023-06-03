using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllExtScript : MonoBehaviour
{
    //public variables
    [Header("Integer")]
    public int TotalSpawns;

    [Header("Float")]
    public float CageRotSpd;
    public float SkyRotSpd;
    public float SpwnXpnt;
    public float SpwnYpnt;
    public float SpwnZpnt;

    [Header("Game Object")]
    public GameObject Target_Green;
    public GameObject Target_Red;
    public GameObject Target_Yellow;
    public GameObject TDEyellow;

    //private variables
    private int TargetColorNum;
    private int StopCount;
    private int MusicManager;
    private float Timer;
    private Vector3 TargetSpwnPnt;
    private GameObject Spawned_Target;
    

    void Awake()
    {
        TargetSpwnPnt = new Vector3(SpwnXpnt, SpwnYpnt, SpwnZpnt);
    }

    void Start()
    {
        MusicManager = Random.Range(1, 51);
        if (MusicManager < 26)
        {
            transform.Find("GamePlayMusic1").GetComponent<AudioSource>().enabled = true;
            transform.Find("GamePlayMusic1").GetComponent<AudioSource>().Play();
        }
        else if (MusicManager > 25)
        {
            transform.Find("GamePlayMusic2").GetComponent<AudioSource>().enabled = true;
            transform.Find("GamePlayMusic2").GetComponent<AudioSource>().Play();
        }
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * SkyRotSpd);
        transform.Rotate(xAngle: 0f, yAngle: CageRotSpd * Time.deltaTime, zAngle: 0f, relativeTo: Space.World);

        Timer += Time.deltaTime;

        if (StopCount < TotalSpawns)
        {
            TargetColorNum = Random.Range( minInclusive: 1, maxExclusive: 151);

            if (TargetColorNum < 61)
            {
                Spawned_Target = Instantiate(original: Target_Green, position: TargetSpwnPnt, rotation: Target_Green.transform.rotation);
                Spawned_Target.SetActive(value: true);
                StopCount++;
            }

            else if (TargetColorNum > 60 && TargetColorNum < 121)
            {
                Spawned_Target = Instantiate(original: Target_Red, position: TargetSpwnPnt, rotation: Target_Red.transform.rotation);
                Spawned_Target.SetActive(value: true);
                StopCount++;
            }
            
            else if (TargetColorNum > 120)
            {
                Spawned_Target = Instantiate(Target_Yellow, TargetSpwnPnt, Target_Yellow.transform.rotation);
                Spawned_Target.SetActive(true);
                StopCount++;
            }
        }

        if (!TDEyellow.GetComponent<ParticleSystem>().isPlaying)
        {
            TDEyellow.GetComponent<AudioSource>().enabled = false;
        }

        if (Timer > 3f)
        {
            StopCount = 0;
            Timer -= 3f;
        }
    }
}