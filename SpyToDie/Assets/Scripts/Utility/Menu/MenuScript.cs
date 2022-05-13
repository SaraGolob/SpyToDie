using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour
{
    public Slider slider;
    public UnityEvent fullSlider;
    public TMP_InputField input;
    public void SinglePlayerPlayButton()
    {
        SceneManager.LoadScene("TutorialControls");
    }
    public void TutorialControlsContinue()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void LoadMultiPlayer()
    {
        SceneManager.LoadScene("LoadingMultiplayerScreen");
    }
    public void ClearInput()
    {
        input.text = "";
    }

}
