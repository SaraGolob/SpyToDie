using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class EndScreenScript : MonoBehaviour
{
    public UnityEvent simpleEventWin;
    public UnityEvent simpleEventLose;
    private void Start()
    {
        if(SceneChange.hasFinished)
        {
            simpleEventWin.Invoke();
        }
        else
        {
            simpleEventLose.Invoke();
        }
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
