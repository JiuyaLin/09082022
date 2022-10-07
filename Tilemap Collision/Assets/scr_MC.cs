using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Tilemaps;

public class scr_MC : MonoBehaviour
{

    public Tilemap map;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
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
