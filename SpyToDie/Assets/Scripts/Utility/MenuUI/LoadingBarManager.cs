using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LoadingBarManager : MonoBehaviour
{
    [Tooltip("How often should the loading bar update")] public float loadingSpeed;
    [HideInInspector]  public float loadingSpeedReset;
    public Slider slider;
    [Tooltip("By how big of a step (out of the max value of the bar) should it update")] public float sliderStepSize;
    public UnityEvent sliderFullEvent;
    // Start is called before the first frame update
    private void Start()
    {
        loadingSpeedReset = loadingSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        loadingSpeed -= Time.deltaTime;
        
        if (loadingSpeed < 0)
        {
            slider.value += sliderStepSize;
            loadingSpeed = loadingSpeedReset;
        }
        if (slider.value >= slider.maxValue)
        {
            sliderFullEvent?.Invoke();
        }
    }
}
