using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FlashingLights : MonoBehaviour
{
    public Color color1, color2;
    public Light2D globalLight;
    [Tooltip("In seconds")]public float flashingSpeed;
    [HideInInspector] public float flashReset;

    private void Start()
    {
        
        flashReset = flashingSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        if (Timer.currentTime <= 30)
        {
            flashingSpeed -= Time.deltaTime;
            if (flashingSpeed < 0)
            {
                globalLight.intensity = 0.8f;
                if (globalLight.color == color1)
                { 
                    globalLight.color = color2;
                }
                else
                {
                    globalLight.color = color1; 
                }
                flashingSpeed = flashReset;
            }
        }
        
    }
}
