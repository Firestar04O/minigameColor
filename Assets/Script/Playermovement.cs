using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public int velocity;
    public int jumpforce;
    private float Horizontal;
    private bool jumpPresssed;
    Rigidbody2D myrgbd;
    void Start()
    {
        myrgbd = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal"); 
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPresssed = true;
        }
    }
    void FixedUpdate()
    {
        myrgbd.velocity = new Vector2(Horizontal * velocity, myrgbd.velocity.y);
        if (jumpPresssed)
        {
            myrgbd.velocity = new Vector2(myrgbd.velocity.x, jumpforce);
            jumpPresssed = false;
        }
    }

}
