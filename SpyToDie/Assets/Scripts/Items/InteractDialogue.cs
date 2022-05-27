using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractDialogue : Interactable
{
    public UnityEvent simpleEvent;
    public DialogueScriptableObject dialogue;
    public override void Interact()
    {
        if (DialogueManager.instance != null)
        {
            DialogueManager.instance.QueueDialogue(dialogue);
        }
    }
}
