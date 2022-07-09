using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 1.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed* Time.deltaTime;
    }
}
