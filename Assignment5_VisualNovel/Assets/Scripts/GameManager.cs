using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //record of all dialogues
    public List<string> phase1Dialogue;
    public List<string> phase2Dialogue;
    public List<string> phase3Dialogue;
    public List<string> phase4Dialogue;

    //holds the currently playing phase
    List<string> currentDialogue;

    //track phase & dialogue index
    int phaseIndex = 0;
    int dialogueIndex = 0;

    //buttons

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
