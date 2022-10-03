using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    private float horizontalMove;
    public float movementMulti;
    //for jumping
    private bool grounded = false; //is MC grounded
    private double jumpCounter = 1; //double jump
    private bool jump = false; //can MC jump

    public float gravityRise = 5f;
    public float gravityFall = 40f;
    public float jumpLimit = 2f;
    public float castDistance = 2f;

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
        
        //jumping press
        if(Input.GetButtonDown("Jump"))
        {
            if (jumpCounter > 0 )
            {
                jump = true;
            }
            else
            {
                jump = false;
            }
        }

        if (grounded)
        {
            jumpCounter = 1;
        }
        
        
    }

    //mostly for physics
    private void FixedUpdate()
    {
        hMove(horizontalMove);

        //jummping input
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpLimit, ForceMode2D.Impulse);
            jump = false;
            jumpCounter = jumpCounter - 1;
        }
        

        //jumping physics
        if(rb.velocity.y >= 0) //rising speed
        {
            rb.gravityScale = gravityRise;
        }else if(rb.velocity.y < 0) //falling speed
        {
            rb.gravityScale = gravityFall;
        }

        //platform detect
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castDistance);
        if(hit.collider != null && hit.transform.name == "Platform")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }



        //Debug.DrawRay(transform.position, Vector2.down * castDistance, new Color(255, 0, 0));

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
