using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_spawn : MonoBehaviour
{
    public GameObject whiteSqaure;
    private GameObject generatedObj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
              
    }

    IEnumerator timer()
    {
        Debug.Log("corutine run");
        //for(float i = 0; i < 10; i++) --> for specific amount of time
        //{
        while (true) //for infinite checking
        {
            generatedObj =  Instantiate(whiteSqaure, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
            
            Destroy(generatedObj, 5);
            yield return new WaitForSeconds(1.5f);
        }
            //}
    }
}
