using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_arrow : MonoBehaviour
{
    Rigidbody2D rb;
    int key;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        key = 1; //nothing pressed
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            key = 1;
        if (Input.GetKey(KeyCode.RightArrow))
            key = 2;
        if (Input.GetKey(KeyCode.UpArrow))
            key = 3;
        if (Input.GetKey(KeyCode.DownArrow))
            key = 4;

        Debug.Log(key);

        if(key != 0)
        {
            StartCoroutine(redundantTest());
        }
        
    }
    
    IEnumerator redundantTest()
    {
        yield return new WaitForSeconds(5);
        while(key == 1)
        {
            rb.AddForce(Vector3.left);
            key = 0;
        }
        while (key == 2)
        {
            rb.AddForce(Vector3.right);
            key = 0;
        }
        while (key == 3)
        {
            rb.AddForce(Vector3.up);
            key = 0;
        }
        while (key == 4)
        {
            rb.AddForce(Vector3.down);
            key = 0;
        }
        yield return null;

    }
}
