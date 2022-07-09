using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 10;

    public GameObject ui_GameOver;

     Rigidbody2D rb;

    void Awake()
    {
         rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        //rb.velocity = Vector2.up * jumpForce;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            rb.AddForce(Vector2.up * jumpForce);

        //if (Input.GetMouseButtonDown(0))
        //{

        //    GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        //}
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground" || col.gameObject.tag == "obstacle")
        {
            Time.timeScale = 0;
            ui_GameOver.SetActive(true);
      
          

        }
    }
}
