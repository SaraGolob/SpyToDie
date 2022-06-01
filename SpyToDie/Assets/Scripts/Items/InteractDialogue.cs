using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractDialogue : RangeTrigger
{
    public override void Update() //does similar thing to generic interact script except it triggers the event as soon as someone enters certain range
    {
        if (Input.GetKeyDown(KeyCode.E) && !PauseMenuScript.isPaused && !DialogueManager.instance.InDialogue && !DialogueManager.instance.InBuffer) //checks if player is pressing the button
        {
            if ((((Vector2)transform.position + offset) - (Vector2)References.instance.playerTransform.position).sqrMagnitude < interactRange * interactRange) //bunch of math, basically checks if player is inside range
            {
                if (repeatThis >= 0)
                {
                    Interact();
                    repeatThis--;
                }
                else
                {
                    this.enabled = false;
                }
            }
        }
    }
}
