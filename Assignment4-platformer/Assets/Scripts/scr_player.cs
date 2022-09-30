using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    //public float panSpeed;
    private float horizontalMove;
    public float movementMulti;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement (left right)
        horizontalMove = Input.GetAxis("Horizontal");
        hMove(horizontalMove);

    }

    //mostly for physics
    private void FixedUpdate()
    {
        
    }

    private void hMove(float move)
    {
        float moveX = move * Time.fixedDeltaTime * movementMulti;
        rb.velocity = new Vector3(moveX, rb.velocity.y);
        if(rb.velocity.x > 0)
        {
            anim.Play("walkR");
        }else if(rb.velocity.x < 0)
        {
            anim.Play("walkL");
        }
        else
        {
            anim.Play("idle");
        }
    }
}
