using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camerFollow : MonoBehaviour
{
    public Camera playerCam;
    public GameObject player;
    private Vector3 camPos;
    private Vector3 oldCamPos;
    private Vector3 mcPos;
    private Vector3 relativePos;
    scr_playerMove moveScript;

    // Start is called before the first frame update
    void Start()
    {
        camPos = playerCam.transform.position;
        oldCamPos = playerCam.transform.position;
        mcPos = player.transform.position;
        relativePos = camPos - mcPos;
        moveScript = player.GetComponent<scr_playerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        camPos = playerCam.transform.position;
        oldCamPos = playerCam.transform.position;
        mcPos = player.transform.position;

        //I will just hard-coded the position for now since that is actually easier
        /*if(camPos.x > -0.38 && camPos.x < 80.81)
        {
            camPos.x = relativePos.x + mcPos.x;
            Debug.Log("normal move");
        }
        else 
        {
            camPos.x = Mathf.Round(oldCamPos.x);
        }*/


        if (moveScript.moveLeft)
        {
            if(camPos.x > -0.38f)
            {
                camPos.x = relativePos.x + mcPos.x;
            }
            
        }
        else
        {
            if (camPos.x < 80.81)
            {
                camPos.x = relativePos.x + mcPos.x;
            }
        }


        playerCam.transform.position = camPos;
        Debug.Log("moved");


    }
}
