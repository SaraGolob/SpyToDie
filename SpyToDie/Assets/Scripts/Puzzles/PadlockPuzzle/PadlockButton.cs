using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadlockButton : MonoBehaviour
{
    public Text number;
    public bool done;

    public void ButtonPressed()
    {
        if (!done)
        {
            number.text = ((int.Parse(number.text) + 1) % 10).ToString();
        }
    }

    public void StopClick()
    {
        done = true;
    }
}
