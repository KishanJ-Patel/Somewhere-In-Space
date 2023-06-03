using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_movement : MonoBehaviour
{
    public float rotate_speed;

    void FixedUpdate()
    {
        transform.Rotate(0f, rotate_speed * Time.deltaTime, 0f, Space.Self);
    }
}
