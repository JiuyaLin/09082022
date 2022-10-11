using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gridX;
    public int gridY;

    public GameObject[] cellObj;

   
    public float offset;

    public GameObject[,] grid; //multidimentional array
    

    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[gridX, gridY];


        for(int x = 0; x < gridX; x++)
        {
            for(int y = 0; y < gridY; y++)
            {
                int randObj = (int)Random.Range(0, cellObj.Length);
                //create new object. (object to clone, the position, the rotation of the object)
                GameObject newCell = Instantiate(cellObj[randObj], transform.position, Quaternion.identity);
                newCell.transform.position += new Vector3(x * offset, y * offset, 0);

                newCell.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
                //newCell.transform.rotation = Random.rotation;
                //newCell.transform.localScale = new Vector3(Random.Range(0.5f, 2), Random.Range(0.5f, 2), Random.Range(0.5f, 2));\


                newCell.GetComponent<scr_cell>().gridX = x;
                newCell.GetComponent<scr_cell>().gridY = y;
                grid[x, y] = newCell;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

