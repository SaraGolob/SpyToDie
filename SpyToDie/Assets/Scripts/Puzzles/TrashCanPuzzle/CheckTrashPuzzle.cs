using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTrashPuzzle : MonoBehaviour
{
    public UnityEvent simpleEvent;
    public TrashCanPuzzle puzzleObject1, puzzleObject2, puzzleObject3, puzzleObject4, puzzleObject5;
    public static bool isSolved;

    void Update()
    {
        if (!isSolved)
        {
            isSolved = puzzleObject1.isActive && puzzleObject2.isActive && puzzleObject3.isActive && puzzleObject4.isActive && puzzleObject5.isActive;

            if (isSolved)
            {
                simpleEvent.Invoke();
                FindObjectOfType<AudioManager>().Play("PuzzleCompleted");
            }
        }
    }
    public void AutoSolve()
    {
        puzzleObject1.isActive = puzzleObject2.isActive = puzzleObject3.isActive = puzzleObject4.isActive = puzzleObject5.isActive = true;
        isSolved = true;
    }

}