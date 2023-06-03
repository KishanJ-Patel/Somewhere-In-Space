using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_movement_2 : MonoBehaviour
{
    private float positionY;
    private float position_manager;
    private float start_positionY;
    private float start_vertical;
    private float end_vertical;
    void Start()
    {
        start_positionY = transform.localPosition.y;
        start_vertical = start_positionY;
        end_vertical = start_positionY - 2;
    }


    void FixedUpdate()
    {
        positionY = transform.localPosition.y;
        if (positionY >= start_vertical)
        {
            position_manager = 1f;
        }

        if (positionY <= end_vertical)
        {
            position_manager = 0f;
        }

        if (position_manager == 1f)
        {
            transform.Translate(0f, -0.4f * Time.deltaTime, 0f, Space.Self);
        }

        if (position_manager == 0f)
        {
            transform.Translate(0f, 0.4f * Time.deltaTime, 0f, Space.Self);
        }

    }
}
