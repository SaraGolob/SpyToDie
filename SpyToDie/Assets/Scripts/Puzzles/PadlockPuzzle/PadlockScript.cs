using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PadlockScript : MonoBehaviour
{
    public Image image;
    public Sprite unlocked;

    [HideInInspector]  public bool IsSolved { get;  set; }

    public Text first, second, third, fourth;

    public string correctCode;

    private string enteredCode;

    public UnityEvent simpleEvent;

    void Update()
    {
        enteredCode = first.text + second.text + third.text + fourth.text;

        if (enteredCode == correctCode)
        {
            IsSolved = true;
            image.sprite = unlocked;
            simpleEvent.Invoke();
            FindObjectOfType<AudioManager>().Play("PuzzleCompleted");
        }
    }
}
