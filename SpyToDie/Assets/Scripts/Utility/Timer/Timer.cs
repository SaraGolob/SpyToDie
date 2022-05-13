using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.Rendering.Universal;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TMP_Text timerText;
    [Header("Timer Settings")]
    [Tooltip("Set this to true if inputed time is in minutes")] public bool currentTimeInMinutes;
    [Tooltip("Time at the point we start counting")] public float startTimer;    
    public static float currentTime;
    [Tooltip("Time the timer has to reach")] public float endingTime;

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
                timerText.color = Color.red;
                enabled = false;
                SceneChange.gameStarted = true;
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
