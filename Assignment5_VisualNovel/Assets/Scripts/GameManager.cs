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
    public List<string> phase5Dialogue;

    //holds the currently playing phase
    List<string> currentDialogue;

    //text for results
    public string endResult;

    //track phase & dialogue index
    int phaseIndex = 0;
    int dialogueIndex = 0;
    int totalPhase = 5;

    //buttons
    public GameObject choiceK;
    public GameObject choiceM;
    public GameObject nextButton;
    public GameObject choiceDead;

    //text showing the dialogue
    public TMP_Text dialogueText;

    //score for both
    int scoreK = 0;
    int scoreM = 0;

    //animator for each
    public Animator animK;
    public Animator animM;

    // Start is called before the first frame update
    void Start()
    {
        //turn off choice buttons
        choiceK.SetActive(false);
        choiceM.SetActive(false);
        choiceDead.SetActive(false);
        //start phase1
        currentDialogue = phase1Dialogue;
        dialogueText.text = currentDialogue[dialogueIndex];
    }


    void SetDialogueText()
    {
        if(phaseIndex < totalPhase)
        {
            dialogueText.text = currentDialogue[dialogueIndex];
        }
    }

    void SetupChoices()
    {
        nextButton.SetActive(false);
        choiceK.SetActive(true);
        choiceM.SetActive(true);
        if(phaseIndex == 4)
        {
            choiceDead.SetActive(true);
        }
    }

    public void AdvanceDialog()
    {
        animM.ResetTrigger("isSelected");
        animK.ResetTrigger("isSelected");
        if (phaseIndex < totalPhase)
        {
            dialogueIndex++;
            SetDialogueText();
            if (dialogueIndex == currentDialogue.Count - 1)
            {
                SetupChoices();
            }
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void GoToNextPhase()
    {
        //turn on next. turn off choices
        nextButton.SetActive(true);
        choiceM.SetActive(false);
        choiceK.SetActive(false);
        choiceDead.SetActive(false);
        //reset dialogue counter
        dialogueIndex = 0;
        //determin phase
        switch (phaseIndex)
        {
            case 0:
                currentDialogue = phase2Dialogue;
                phaseIndex = 1;
                break;
            case 1:
                currentDialogue = phase3Dialogue;
                phaseIndex = 2;
                break;
            case 2:
                currentDialogue = phase4Dialogue;
                phaseIndex = 3;
                break;
            case 3:
                currentDialogue = phase5Dialogue;
                phaseIndex = 4;
                break;
            case 4:
                phaseIndex = 5;
                GiveResults();
                break;
        }
        SetDialogueText();
    }


    public void KurisuChoice()
    {
        GoToNextPhase();
        if(phaseIndex != 0)
        {
            animK.SetTrigger("isSelected");
            scoreK++;
        }
        
    }

    public void MayuriChoice()
    {
        GoToNextPhase();
        if(phaseIndex != 0)
        {
            animM.SetTrigger("isSelected");
            scoreM++;
        }
    }

    void GiveResults()
    {
        dialogueText.text = endResult;
    }
}
