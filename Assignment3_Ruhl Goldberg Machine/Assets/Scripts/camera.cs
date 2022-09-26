using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject pc;
    private Vector3 playerPos;
    private Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = pc.transform.position;
        cameraPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = pc.transform.position;
        cameraPos = playerPos;
        cameraPos.z = -10;
        transform.position = cameraPos;
    }
}
