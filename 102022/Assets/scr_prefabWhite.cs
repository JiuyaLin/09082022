using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_prefabWhite : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
