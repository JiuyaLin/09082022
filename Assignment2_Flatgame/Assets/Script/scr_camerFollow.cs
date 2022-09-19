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

        //I will just hard-coded the position for now since that is actually easier
        if(camPos.x > -0.38 && camPos.x < 80.81)
        {
            camPos.x = relativePos.x + mcPos.x;
            Debug.Log("normal move");
        }else if(camPos.x < -0.38)
        {
            camPos.x = (float)-0.379;
            Debug.Log("left Bound");
        }else if(camPos.x > 80.81)
        {
            camPos.x = (float)80.8;
        }
        

        playerCam.transform.position = camPos;
        Debug.Log("moved");


    }
}
