using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_movement : MonoBehaviour
{
    private float positionY;
    private float position_manager;
    private float start_positionY;
    private float start_vertical;
    private float end_vertical;
    private float frames;
    public float framecount;
    public float speed;
    public float rotate_speed;

    void Start()
    {
        frames = 0f;
        start_positionY = transform.localPosition.y;
        start_vertical = start_positionY;
        end_vertical = start_positionY + 1;
    }


    void Update()
    {
        frames++;
        
        if (gameObject.CompareTag("Platform_Line1") && frames >= framecount)
       {
            transform.Rotate(0f, rotate_speed * Time.deltaTime, 0f, Space.Self);
            positionY = transform.localPosition.y;
            if (positionY <= start_vertical)
            {
                position_manager = 1f;
            }

            if (positionY >= end_vertical)
            {
                position_manager = 0f;
            }

            if (position_manager == 1f)
            {
                transform.Translate(0f, speed * Time.deltaTime, 0f, Space.Self);
            }

            if (position_manager == 0f)
            {
                transform.Translate(0f, speed * -1f * Time.deltaTime, 0f, Space.Self);
            }
        }

        if (gameObject.CompareTag("Platform_Line2") && frames >= framecount)
        {
            transform.Rotate(0f, rotate_speed * -1f * Time.deltaTime, 0f, Space.Self);

            positionY = transform.localPosition.y;
            if (positionY <= start_vertical)
            {
                position_manager = 1f;
            }

            if (positionY >= end_vertical)
            {
                position_manager = 0f;
            }

            if (position_manager == 1f)
            {
                transform.Translate(0f, speed * Time.deltaTime, 0f, Space.Self);
            }

            if (position_manager == 0f)
            {
                transform.Translate(0f, speed * -1f * Time.deltaTime, 0f, Space.Self);
            }
        }

        if (gameObject.CompareTag("Platform_Line3") && frames >= framecount)
        {
            transform.Rotate(0f, rotate_speed * Time.deltaTime, 0f, Space.Self);
            positionY = transform.localPosition.y;
            if (positionY <= start_vertical)
            {
                position_manager = 1f;
            }

            if (positionY >= end_vertical)
            {
                position_manager = 0f;
            }

            if (position_manager == 1f)
            {
                transform.Translate(0f, speed * Time.deltaTime, 0f, Space.Self);
            }

            if (position_manager == 0f)
            {
                transform.Translate(0f, speed * -1f * Time.deltaTime, 0f, Space.Self);
            }
        }

        if (gameObject.CompareTag("Platform_Line4") && frames >= framecount)
        {
            transform.Rotate(0f, rotate_speed * Time.deltaTime, 0f, Space.Self);
            positionY = transform.localPosition.y;
            if (positionY <= start_vertical)
            {
                position_manager = 1f;
            }

            if (positionY >= end_vertical)
            {
                position_manager = 0f;
            }

            if (position_manager == 1f)
            {
                transform.Translate(0f, speed * Time.deltaTime, 0f, Space.Self);
            }

            if (position_manager == 0f)
            {
                transform.Translate(0f, speed * -1f * Time.deltaTime, 0f, Space.Self);
            }
        }
    }
}
