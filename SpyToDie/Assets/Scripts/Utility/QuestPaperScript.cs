using UnityEngine;
using UnityEngine.Events;

public class QuestPaperScript : MonoBehaviour
{
    public GameObject questPaper, smallQuestPaper, firstCheckMark, secondCheckMark, thirdCheckMark;
    public UnityEvent resetColor;
    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (questPaper.activeSelf)
            {
                resetColor.Invoke();
                smallQuestPaper.SetActive(true);
                questPaper.SetActive(false);
            }
            else
            {
                resetColor.Invoke();
                smallQuestPaper.SetActive(false);
                questPaper.SetActive(true);
            }
        }

        if (CheckTrashPuzzle.isSolved)
            firstCheckMark.SetActive(true);
        else
            firstCheckMark.SetActive(false);

        if (NumberPad.isSolved)
            secondCheckMark.SetActive(true);
        else
            secondCheckMark.SetActive(false);

        if (ButtonLogic.isSolved)
            thirdCheckMark.SetActive(true);
        else
            thirdCheckMark.SetActive(false);
    }
}
