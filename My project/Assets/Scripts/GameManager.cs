using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject cellObj;

    public int gridX;
    public int gridY;
    public float offset;



    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < gridX; x++)
        {
            for(int y = 0; y < gridY; y++)
            {
                //create new object. (object to clone, the position, the rotation of the object)
                GameObject newCell = Instantiate(cellObj, transform.position, Quaternion.identity);
                newCell.transform.position += new Vector3(x * offset, y * offset, 0);

                newCell.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
                newCell.transform.rotation = Random.rotation;
                newCell.transform.localScale = new Vector3(Random.Range(0.5f, 2), Random.Range(0.5f, 2), Random.Range(0.5f, 2));
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
