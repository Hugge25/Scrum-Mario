using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jump = 500;
    private float speed = 5f;
    void Start()  // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() // Update is called once per frame
    {

        Vector3 movement = new Vector3();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
        if(Input.GetKey(KeyCode.S))
        {
            
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }

        movement.Normalize();
        transform.position += movement * Time.deltaTime * speed;
    }
}
