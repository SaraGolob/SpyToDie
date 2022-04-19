using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class NumberDisplay : MonoBehaviour
{
    public static string numbersToDisplay = "";
    public Text display;
    public static bool limitReached;
    public static string correctAnswer = "1234";

    // Update is called once per frame
    void Update()
    {
        display.text = numbersToDisplay.ToString();
        if (display.text.Length > 3)
        {
            limitReached = true;
        }
        else
        {
            limitReached = false;
        }
    }
}
