using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class Countdown_Timer : MonoBehaviour
{
    [Header("Component")]
    public TMP_Text timerText;

    [Header("Timer Settings")]
    public bool currentTimeInMinutes; //set this to true if inputed current time is in minutes and not seconds
    public float currentTime;
    public float endingTime;

    [Header("Penalties")]
    public bool hasPenalty;
    public float penaltySeconds;

    void Start()
    {
        if (currentTimeInMinutes) //converts time to seconds in case we input minutes
        {
            currentTime = currentTime * 60;
        }
    }
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= endingTime)
        {
            currentTime = endingTime;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }
        SetTimerText();
    }

    private void SetTimerText()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //private void ChangeTextColor() //thread method to change text color
    //{
    //    if (timerText.color == Color.red) //if its already red we change it to yellow
    //    {
    //        timerText.color = Color.yellow;
    //        Thread.Sleep(1000);
    //        timerText.color = Color.red;
    //    }
    //    else
    //    {
    //        timerText.color = Color.red; //otherwise it blinks red
    //        Thread.Sleep(1000);
    //        timerText.color = Color.white;
    //    }
    //} 
    public void ApplyPenalty()
    {
        if (hasPenalty)
        {
            currentTime = currentTime - penaltySeconds;
            //ChangeColor.Start();
        }
    }
    //IEnumerator ChangeColor()
    //{
    //    Color c = timerText.Color;
    //    timerText.color = Color.yellow;
    //    yield return new WaitForSeconds(1f);
    //    timerText.color = c;
    //    yield return null;
    //}
}
