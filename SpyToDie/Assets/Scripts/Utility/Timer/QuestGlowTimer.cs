using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGlowTimer : MonoBehaviour
{
    public Image questPaper;
    public static Color glowColor = Color.green;


    public void Glow()
    {
       questPaper.color = glowColor;
    }
    public void ResetColor()
    {
        questPaper.color = Color.white;
    }
}
