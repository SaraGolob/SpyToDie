using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class NumberPad : MonoBehaviour
{
    public Button button;
    public UnityEvent simpleEvent = new UnityEvent();
    public UnityEvent penaltyEvent = new UnityEvent();
    // Start is called before the first frame update
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
            simpleEvent.Invoke();
        }
        else
        {
            penaltyEvent.Invoke();
        }

    }
}
