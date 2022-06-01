using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractDialogue : RangeTrigger
{
    private bool oldKeyStatePressed;
    public override void Update() //does similar thing to generic interact script except it triggers the event as soon as someone enters certain range
    {
        if(oldKeyStatePressed && Input.GetKeyDown(KeyCode.E))
        {
            oldKeyStatePressed = false;
            return;
        }
        if (repeatThis >= 0)
        {
            if (Input.GetKeyDown(KeyCode.E) && !PauseMenuScript.isPaused && !DialogueManager.instance.isInDialogue) //checks if player is pressing the button
            {
                if ((((Vector2)transform.position + offset) - (Vector2)References.instance.playerTransform.position).sqrMagnitude < interactRange * interactRange) //bunch of math, basically checks if player is inside range
                {
                    oldKeyStatePressed = true;
                    Interact();
                    repeatThis--;
                }
            }
        }
        if (DialogueManager.instance.dialogueFinsihed)
        {
            dialogueEvent?.Invoke();
        }
    }
}
