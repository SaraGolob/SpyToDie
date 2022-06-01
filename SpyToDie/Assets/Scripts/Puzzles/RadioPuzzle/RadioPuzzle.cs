using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RadioPuzzle : MonoBehaviour
{
    public Slider slider;
    private bool rightLocation;
    public DialogueScriptableObject dialogue;
    public UnityEvent simpleEvent;

    public void CheckFrequency()
    {
        if (slider.value == 4 && rightLocation)
        {
            if (DialogueManager.instance != null)
            {
                simpleEvent?.Invoke();
                gameObject.SetActive(false);
                DialogueManager.instance.QueueDialogue(dialogue);
                FindObjectOfType<AudioManager>().Play("PuzzleCompleted");
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
