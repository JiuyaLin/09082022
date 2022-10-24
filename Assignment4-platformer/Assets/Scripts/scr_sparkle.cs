using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_sparkle : MonoBehaviour
{
    public AudioSource source;
    public scr_gameManager gMscript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            source.pitch = Random.Range(0.4f, 1.6f); 
            source.Play();
            Destroy(gameObject);
            gMscript.score++;
            gMscript.updateScore();
        }
    }
}
