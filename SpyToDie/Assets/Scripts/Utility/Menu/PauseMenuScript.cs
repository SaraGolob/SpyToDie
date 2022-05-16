using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    public static bool isPaused;
    [Tooltip("The pause menu scene")] public GameObject pauseMenu;
    public UnityEvent simpleEventPause;
    public UnityEvent simpleEventUnpause;
    public static bool canPause { get ; set; }
     
    public void Start()
    {
        canPause = true;
        isPaused = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused && !DialogueManager.instance.isInDialogue && canPause)
        {
            simpleEventPause.Invoke();
            ChangePause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused && pauseMenu.activeSelf)
        {
            simpleEventUnpause.Invoke();
            ChangePause();
        }
    }

    public void ChangePause()
    {
        isPaused = !isPaused;
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
