using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_danger : MonoBehaviour
{
    public GameObject MC;
    public AudioSource source;
    public scr_gameManager gMscript;

    private Animator anim;
    private Animator MCanim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        MCanim = MC.GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gMscript.life--;
            source.Play();
            gMscript.updateLife();
            anim.Play("danger");
            MCanim.Play("fallIn");

            StartCoroutine(pauseTeleport());
            
        }
    }

    IEnumerator pauseTeleport()
    {
        yield return new WaitForSeconds(1);
        MC.transform.position = gMscript.checkedPosition;
        yield break;
    }
    

}
