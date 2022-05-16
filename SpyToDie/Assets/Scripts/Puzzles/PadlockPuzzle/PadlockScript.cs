using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadlockScript : MonoBehaviour
{
    public Text first, second, third, fourth;

    public string correctCode;

    private string enteredCode;

    void Update()
    {
        enteredCode = first.text + second.text + third.text + fourth.text;

        if (enteredCode == correctCode)
        {
            first.text = "�";
            second.text = "�";
            third.text = "�";
            fourth.text = "�";
        }
    }
}
