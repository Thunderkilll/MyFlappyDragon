using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    private Vector3 range;

    void FixedUpdate()
    {
        transform.position = new Vector3(range.x +player.position.x,
            transform.position.y, range.z + player.position.z);
    }  
    
    void Start()
    {
        range = transform.position - player.position;
    }
}
