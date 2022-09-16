using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerMove : MonoBehaviour
{
    public float speed;
    public float decelerate;
    private float hSpeed = 0;
    private float vSpeed = 0;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        //slow down gradually
        Vector3 curPos = transform.position;
        hSpeed = (float)(decelerate * hSpeed);
        Debug.Log("hSpeed: " + hSpeed);
        vSpeed = (float)(decelerate * vSpeed);
        Debug.Log("vSpeed: " + vSpeed);
        //trim down the number
        hSpeed = (float)(Mathf.Ceil(hSpeed * 10) / 10.0);
        //vSpeed = (float)(Mathf.Ceil(vSpeed * 10) / 10);



        //move the player character
        if (Input.GetKey(KeyCode.A))
        {
            hSpeed = -speed;
        }else if (Input.GetKey(KeyCode.D))
        {
            hSpeed = speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vSpeed = speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vSpeed = -speed;
        }
        
        curPos.x += hSpeed;
        curPos.y += vSpeed;

        transform.position = curPos;




        //change the animation


    }
}
