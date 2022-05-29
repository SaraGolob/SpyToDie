using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HackerTypeEnd : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject dialogueManager;
    public GameObject newDialogueBox;
    public TMPro.TMP_Text newTextBox;
    public DialogueScriptableObject dialogue;
    public UnityEvent scriptEndEvent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PhotonNetwork.CurrentRoom.MaxPlayers = 3;
        }
        if (DialogueManager.instance.dialogueFinsihed)
        {
            scriptEndEvent.Invoke();
        }
    }
    public void ChangeDialogueManager()
    {
        dialogueManager.GetComponent<DialogueManager>().dialogueBox = newDialogueBox;
        dialogueManager.GetComponent<DialogueManager>().dialogueText = newTextBox;
        dialogueManager.GetComponent<DialogueManager>().textDelay = 0.01f;

    }
    public void TriggerHackerDialogue()
    {
        if (DialogueManager.instance != null)
        {
            DialogueManager.instance.QueueDialogue(dialogue);
        }
    }
}
