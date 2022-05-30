using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioPuzzle : MonoBehaviour
{
    Slider slider;
    private bool rightLocation;
    DialogueScriptableObject dialogue;

    public void CheckFrequency()
    {
        if (slider.value == 4 && rightLocation)
        {
            if (DialogueManager.instance != null)
            {
                DialogueManager.instance.QueueDialogue(dialogue);
            }
        }
    }
    public void RightLocation()
    {
        rightLocation = true;
        CheckFrequency();
    }
    public void WrongLocation()
    {
        rightLocation = false;
    }
}
