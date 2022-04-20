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
    public float startTimer;
    public static float currentTime;

    public float endingTime;

    [Header("Penalties")]
    public bool hasPenalty;
    public float penaltySeconds;

    
    void Start()
    {

        if (currentTimeInMinutes) //converts time to seconds in case we input minutes
        {
            currentTime = startTimer * 60;
        }
        else
        {
            currentTime = startTimer;
        }
    }
    void Update()
    {
        
        currentTime -= Time.deltaTime;
        if (currentTime <= 10 )
        {
            timerText.color = Color.red;
            if (currentTime <= endingTime)
            {
                currentTime = endingTime;
                SetTimerText();
                timerText.color = Color.red;
                enabled = false;

            }
        }
       
        SetTimerText();
    }

    private void SetTimerText()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void ApplyPenalty()
    {
        if (hasPenalty)
        {
            currentTime = currentTime - penaltySeconds;
            StartCoroutine(ChangeColor());
        }
    }
    IEnumerator ChangeColor()
    {
        Color c = timerText.color;
        timerText.color = Color.yellow;
        yield return new WaitForSeconds(1f);
        timerText.color = c;
        yield return null;
    }
}
