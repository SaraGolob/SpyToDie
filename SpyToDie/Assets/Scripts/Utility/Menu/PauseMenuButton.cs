using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PauseMenuButton : MonoBehaviour
{
    public GameObject pauseMenu, optionsMenu, controlsMenu;
    public UnityEvent pause;
    public UnityEvent unPause;
    
    
    // Update is called once per frame
    public void ClickPauseButton()
    {
        if (!PauseMenuScript.isPaused && !DialogueManager.instance.isInDialogue && PauseMenuScript.canPause)
        {
            pause.Invoke();
            PauseMenuScript.isPaused=!PauseMenuScript.isPaused;
        }
        else if (PauseMenuScript.isPaused && (pauseMenu.activeSelf || optionsMenu.activeSelf || controlsMenu.activeSelf))
        {
            unPause.Invoke();
            PauseMenuScript.isPaused = !PauseMenuScript.isPaused;
        }
    }
}
