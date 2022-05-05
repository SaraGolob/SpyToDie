using UnityEngine;

public class QuestPaperScript : MonoBehaviour
{
    public GameObject questPaper, smallQuestPaper, firstCheckMark, secondCheckMark, thirdCheckMark;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (questPaper.activeSelf)
            {
                smallQuestPaper.SetActive(true);
                questPaper.SetActive(false);
            }
            else
            {
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
