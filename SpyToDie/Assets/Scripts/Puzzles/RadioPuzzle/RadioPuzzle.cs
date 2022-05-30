using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioPuzzle : MonoBehaviour
{
    public Slider slider;
    private bool rightLocation;
    public DialogueScriptableObject dialogue;

    public void CheckFrequency()
    {
        if (slider.value == 4 && rightLocation)
        {
            if (DialogueManager.instance != null)
            {
                gameObject.SetActive(false);
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
