using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove;
    public float movementMultiplier;

    private bool grounded;
    public float castDistance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = false;
        castDistance = 1.9f;

    }

    // Update is called once per frame
    //tired to fps
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

    }

    //physics always calculated on FixedUpdate
    //no input things in FixedUpdate
    private void FixedUpdate()
    {
        HorizontalMove(horizontalMove);
        //Physics.RayCast(Origin, direction, maxDistance)
        //Scripting API: https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
        //Vector2.down = Vector2(0, -1) (shorthand version)
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castDistance); //An inbuild physics function.
              //Debug.DrawRay(transform.position, Vector2.down*castDistance, new Color(255,0,0));
        if(hit.collider != null) //moving player to layer-> Ignored RayCast so the Log does not print player name
        {
            Debug.Log(hit.transform.name);
        }
        
        
    }

    void HorizontalMove(float toMove)
    {
        float moveX = toMove * Time.fixedDeltaTime * movementMultiplier; //the time that fixed update is running
        rb.velocity = new Vector3(moveX, rb.velocity.y); 
    }
}


//player jumping. On the ground jumping.
    //check the player is on the ground.
        //RayCasting: draw a ray, goes down, detect if the player is on the ground.
