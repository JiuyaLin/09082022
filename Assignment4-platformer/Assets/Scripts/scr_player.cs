using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_player : MonoBehaviour
{
    Rigidbody2D rb;
    public float panSpeed;
    private float horizontalMove;
    public float movementMulti;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        panSpeed = 0.1f;
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
            //walk right
        }else if(rb.velocity.x < 0)
        {

        }
    }
}
