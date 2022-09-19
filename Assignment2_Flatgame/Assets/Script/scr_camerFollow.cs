using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camerFollow : MonoBehaviour
{
    public Camera playerCam;
    public GameObject player;
    private Vector3 camPos;
    private Vector3 mcPos;
    private Vector3 relativePos;

    // Start is called before the first frame update
    void Start()
    {
        camPos = playerCam.transform.position;
        mcPos = player.transform.position;
        relativePos = camPos - mcPos;
    }

    // Update is called once per frame
    void Update()
    {
        camPos = playerCam.transform.position;
        mcPos = player.transform.position;

        camPos.x = relativePos.x + mcPos.x;

        playerCam.transform.position = camPos;
        Debug.Log("moved");


    }
}
