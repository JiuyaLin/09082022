using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    AudioSource collisionSnd;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collisionSnd = GetComponent<AudioSource>();
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

    void OnCollisionEnter2D(Collision2D other)
    {
        collisionSnd.pitch = Random.Range(0.5f, 2.5f);
        collisionSnd.volume = Random.Range(0f, 1.0f);
        collisionSnd.Play();
        Debug.Log("collided");
    }

}
