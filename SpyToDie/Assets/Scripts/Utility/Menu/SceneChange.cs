using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public static bool hasFinished;
    private void Start()
    {
        CheckTrashPuzzle.isSolved = false;
        NumberPad.isSolved = false;
        ButtonLogic.isSolved = false;
    }
    void Update()
    {
        if(CheckTrashPuzzle.isSolved && NumberPad.isSolved && ButtonLogic.isSolved)
        {
            hasFinished = true;
            SceneManager.LoadScene("TextScroller");
        }
        else if (Timer.currentTime<=0)
        { 
            SceneManager.LoadScene("TextScroller");
         }
    }
}
