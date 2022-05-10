using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
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
}
