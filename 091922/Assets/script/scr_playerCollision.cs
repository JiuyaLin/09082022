using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerCollision : MonoBehaviour
{
    public AudioClip hitSnd;
    AudioSource mySource;

    public AudioClip[] allSounds;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log(gameObject.transform.name);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        if(collision.gameObject.transform.name == "Square (2)")
        {
            int randSound = Random.Range(0, allSounds.Length);
            mySource.PlayOneShot(hitSnd);
            Debug.Log("play sound");
        }
        
        //Debug.Log(collision.gameObject.transform.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(Collider.gameObject.transform.name);
    }
}
