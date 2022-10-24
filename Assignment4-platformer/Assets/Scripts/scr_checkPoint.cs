using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_checkPoint : MonoBehaviour
{

    public AudioSource source;
    public scr_gameManager gMscript;

    public SpriteRenderer sr;
    public Sprite checkedSprite;

    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            source.Play();
            sr.sprite = checkedSprite;
            gMscript.checkedPosition = this.transform.position;
        }
    }
}
