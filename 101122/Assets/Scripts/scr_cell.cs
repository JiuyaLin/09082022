using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cell : MonoBehaviour
{
    public int gridX;
    public int gridY;

    GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gridX > 0)
        {
            GameObject leftCell = myManager.grid[gridX - 1, gridY];
            Debug.Log("Left is " + leftCell.transform.name);
        }
        if(gridX < myManager.gridX - 1)
        {
            GameObject rightCell = myManager.grid[gridX + 1, gridY];
            Debug.Log("Right is " + rightCell.transform.name);
        }

        

        if (gridY > 0)
        {
            GameObject upCell = myManager.grid[gridX, gridY - 1];

        }
        
        
    }
}
