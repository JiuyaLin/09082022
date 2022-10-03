using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove;
    public float movementMultiplier;

    //check if the pc is grounded
    private bool grounded;
    public float castDistance;

    //for jumping
    public float jumpLimit = 0.2f;
    public float gravityScale = 5f;
    public float gravityFall = 40f;
    private bool jump = false;

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        grounded = false;
        castDistance = 1.9f;

    }

    // Update is called once per frame
    //tired to fps
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        //jumping
        if (Input.GetButtonDown("Jump") && grounded) //jump default to space
        {
            jump = true;
        }
    }

    //physics always calculated on FixedUpdate
    //no input things in FixedUpdate
    private void FixedUpdate()
    {
        HorizontalMove(horizontalMove);

        if (jump)
        {
            rb.AddForce(Vector2.up * jumpLimit, ForceMode2D.Impulse); //impulse apply the impulse force instantly.
            jump = false;
        }

        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = gravityFall;
        }


        //Physics.RayCast(Origin, direction, maxDistance)
        //Scripting API: https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
        //Vector2.down = Vector2(0, -1) (shorthand version)
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castDistance); //An inbuild physics function.
        //Debug.DrawRay(transform.position, Vector2.down*castDistance, new Color(255,0,0));

        //moving player to layer-> Ignored RayCast so the Log does not print player name
        if (hit.collider != null && hit.transform.name == "platform")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }


    }

    void HorizontalMove(float toMove)
    {
        float moveX = toMove * Time.fixedDeltaTime * movementMultiplier; //the time that fixed update is running
        rb.velocity = new Vector3(moveX, rb.velocity.y);
        if (rb.velocity.x > 0 || rb.velocity.x < 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}

//player jumping. On the ground jumping.
    //check the player is on the ground.
        //RayCasting: draw a ray, goes down, detect if the player is on the ground.
