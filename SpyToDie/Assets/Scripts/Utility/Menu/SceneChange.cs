using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public static bool hasFinished;
    // Update is called once per frame
    void Update()
    {
        if(CheckTrashPuzzle.isSolved && NumberPad.isSolved && ButtonLogic.isSolved)
        {
            hasFinished = true;
            SceneManager.LoadScene("EndScreen");
        }
        else if (Timer.currentTime<=0)
        { 
            SceneManager.LoadScene("EndScreen");
         }
    }
}
