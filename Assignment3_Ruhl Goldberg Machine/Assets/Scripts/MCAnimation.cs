using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x > 0.2)
        {
            anim.Play("MoveR");
        }else if (rb.velocity.x < -0.2)
        {
            anim.Play("MoveL");
        }
        else
        {
            anim.Play("Idle");
        }
    }
}
