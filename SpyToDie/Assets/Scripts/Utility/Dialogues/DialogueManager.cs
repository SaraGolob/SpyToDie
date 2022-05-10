using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public GameObject dialogueBox;
    public float textDelay = 0.1f;
    public bool InDialogue { get; private set; }
    public bool InBuffer { get; private set; }
    public static DialogueManager instance;
    private Queue<DialogueScriptableObject.Info> dialogueQueue;
    private bool isTyping;
    private DialogueScriptableObject currentDialogue;
    private string completeText;
    public bool dialogueFinsihed = false;
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            dialogueQueue = new Queue<DialogueScriptableObject.Info>();
            InDialogue = false;
            InBuffer = false;
        }
        else
        {
            Destroy(gameObject); //if there are two dialogue managers for example when changing scene, it destroys the old one
            return;
        }
    }
    void Update()
    {
        if (InDialogue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DequeueDialogue();
            }
        }
    }
    public void QueueDialogue(DialogueScriptableObject dialogue)
    {
        dialogueFinsihed = false ;
        if (InDialogue)
        {
            return;
        }
        References.instance.playerMovement.PauseMovement = true;
        InDialogue = true;
        InBuffer = true;
        StartCoroutine(Buffer());
        currentDialogue = dialogue;
        //if (References.instance.playerTransform.position.y <= 0)
        //{
        //    dialogueBox. //if player is below 0 show text box above ?
        //}

        dialogueBox.SetActive(true);
        dialogueQueue.Clear();
        foreach(DialogueScriptableObject.Info line in dialogue.dialogueInfo)
        {
            dialogueQueue.Enqueue(line);
        }
        DequeueDialogue();
    }
    public void DequeueDialogue()
    {
        if (isTyping)
        {
            if (InBuffer)
            {
                return;
            }
            CompleteText();
            StopAllCoroutines();
            isTyping = false;
            return;
        }
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }
        DialogueScriptableObject.Info info = dialogueQueue.Dequeue();
        completeText = info.dialogue;
        dialogueText.text = "";
        StartCoroutine(TypeText(info));
    }
    private void CompleteText()
    {
        dialogueText.text = completeText;
    }
    private void EndDialogue()
    {
        dialogueBox.SetActive(false);
        InBuffer = true;
        StartCoroutine(Buffer());
        InDialogue = false;
        References.instance.playerMovement.PauseMovement = false;
        dialogueFinsihed = true;


    }
    public IEnumerator Buffer()
    {
        yield return new WaitForSeconds(0.1f);
        InBuffer = false;
    }
    public IEnumerator TypeText(DialogueScriptableObject.Info info)
    {
        isTyping = true;
        foreach(char c in info.dialogue.ToCharArray())
        {
            yield return new WaitForSeconds(textDelay);
            dialogueText.text += c;
        }
        isTyping = false;
    }
}
