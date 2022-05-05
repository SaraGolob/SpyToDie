using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class NumberPad : MonoBehaviour
{
    public static bool isSolved;
    public Button button;
    public UnityEvent simpleEvent = new UnityEvent();
    public UnityEvent penaltyEvent = new UnityEvent();

    public void Start()
    {
        isSolved = false;
    }
    public void PressButton()
    {
        if (!NumberDisplay.limitReached)
        {
            NumberDisplay.numbersToDisplay += button.name.ToString();
        }
    }
    public void CleanDisplay()
    {
        NumberDisplay.numbersToDisplay = "";
    }
    public void CheckCode()
    {
        if (NumberDisplay.numbersToDisplay == NumberDisplay.correctAnswer)
        {
            isSolved = true;
            simpleEvent.Invoke();
        }
        else
        {
            penaltyEvent.Invoke();
        }

    }
}
