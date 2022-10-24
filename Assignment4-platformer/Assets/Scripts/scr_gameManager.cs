using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scr_gameManager : MonoBehaviour
{
    public TMP_Text scoreCount;
    public TMP_Text lifeCount;
    public int score;
    public int life;
    public bool deathCheck;

    public GameObject MC;
    public Vector3 checkedPosition;

    // Start is called before the first frame update
    void Start()
    {
        deathCheck = false;
        updateScore();
        updateLife();
        checkedPosition = MC.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(life == 0)
        {
            deathCheck = true;
        }
    }

    public void updateScore()
    {
        Debug.Log("Score updated");
        scoreCount.text = "Score: " + score.ToString();
    }

    public void updateLife()
    {
        lifeCount.text = "Life : " + life.ToString();
        if(life == 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
