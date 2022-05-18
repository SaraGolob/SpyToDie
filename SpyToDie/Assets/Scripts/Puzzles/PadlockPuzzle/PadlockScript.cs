using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadlockScript : MonoBehaviour
{
    public Image image;
    public Sprite spriteOfLocker;
    public GameObject doorObjectClose;
    public GameObject doorObjectOpen;
    

    public Text first, second, third, fourth;

    public string correctCode;

    private string enteredCode;

    void Update()
    {
        enteredCode = first.text + second.text + third.text + fourth.text;

        if (enteredCode == correctCode)
        {
            image.sprite = spriteOfLocker;
            doorObjectClose.SetActive(false);
            doorObjectOpen.SetActive(true);
        }
    }
}
