using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
