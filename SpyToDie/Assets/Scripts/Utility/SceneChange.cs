using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public static bool hasFinished;
    // Update is called once per frame
    void Update()
    {
        if(CheckPuzzle.isSolved && NumberPad.isSolved && ButtonLogic.isSolved)
        {
            hasFinished = true;
            SceneManager.LoadScene("EndScreen");
        }
        //else if (Countdown_Timer.timeIsOut)
        //{
            //SceneManager.LoadScene("EndScreen");
        //}
    }
}
