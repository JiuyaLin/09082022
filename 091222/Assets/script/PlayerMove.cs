using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float score;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello,World");
    }
    
    // Update is called once per frame
    void Update()
    {

        //move the object along with the mouse
        /* Vector3 currentPosition = transform.position;
        Vector3 mousePos = Input.mousePosition;
        currentPosition = Camera.main.ScreenToWorldPoint(mousePos);
        currentPosition.z = 0;
        transform.position = currentPosition;*/

        //move the object with wasd
        Vector3 currentPosition = transform.position;
        if (Input.GetKey(KeyCode.W)) //or KeyCode.W = "w"
        {
            currentPosition.y += speed;
        }else if (Input.GetKey(KeyCode.S)) //or KeyCode.S = "s"
        {
            currentPosition.y -= speed;
        }
        if (Input.GetKey(KeyCode.A)) //or KeyCode.A = "a"
        {
            currentPosition.x -= speed;
        }else if (Input.GetKey(KeyCode.D)) //or KeyCode.D = "d"
        {
            currentPosition.x += speed;
        }
        //KeyCode.UpArrow = "up", etc.
        transform.position = currentPosition;
    }

    //type of variables: float, string, bool, char, etc.
        //float: any numbers with decimals. *: f after the word. ex. 10.5f.
    //public allow other script to access the variable & put the number into the inspector

    //camera as the child of the player
        //code?

}
