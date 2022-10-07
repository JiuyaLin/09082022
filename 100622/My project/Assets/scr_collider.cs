using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Tilemaps;

public class scr_collider : MonoBehaviour
{
    private float hSpeed;
    private float vSpeed;

    public Tilemap map;

    // Start is called before the first frame update
    void Start()
    {
        hSpeed = 1f;
        vSpeed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = transform.position;

        if(Input.GetKeyDown(KeyCode.A))
        {
            curPos.x -= hSpeed;
        }else if(Input.GetKeyDown(KeyCode.D))
        {
            curPos.x += hSpeed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            curPos.y += vSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            curPos.y -= vSpeed;
        }

        transform.position = curPos;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("collided");

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject tiles = GameObject.FindGameObjectWithTag("colliderTile");
        Vector3 hitPosition = player.transform.position;

        if (col.gameObject == tiles)
        {
            Debug.Log("collided with player");
            map.SetTile(map.WorldToCell(hitPosition), null);
        }
    }

}
