using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckTrashPuzzle : MonoBehaviour
{
    public UnityEvent simpleEvent;
    public bool puzzleObject1, puzzleObject2, puzzleObject3, puzzleObject4, puzzleObject5;
    public static bool isSolved;

    void Update()
    {
        if (!isSolved)
        {
            puzzleObject1 = GameObject.Find("PuzzleObject1").GetComponent<TrashCanPuzzle>().isActive;
            puzzleObject2 = GameObject.Find("PuzzleObject2").GetComponent<TrashCanPuzzle>().isActive;
            puzzleObject3 = GameObject.Find("PuzzleObject3").GetComponent<TrashCanPuzzle>().isActive;
            puzzleObject4 = GameObject.Find("PuzzleObject4").GetComponent<TrashCanPuzzle>().isActive;
            puzzleObject5 = GameObject.Find("PuzzleObject5").GetComponent<TrashCanPuzzle>().isActive;

            isSolved = puzzleObject1 && puzzleObject2 && puzzleObject3 && puzzleObject4 && puzzleObject5;

            if (isSolved)
            {
                simpleEvent.Invoke();
                FindObjectOfType<AudioManager>().Play("PuzzleCompleted");
            }
        }
    }
    public void AutoSolve()
    {
        GameObject.Find("PuzzleObject1").GetComponent<TrashCanPuzzle>().isActive = true;
        GameObject.Find("PuzzleObject2").GetComponent<TrashCanPuzzle>().isActive = true;
        GameObject.Find("PuzzleObject3").GetComponent<TrashCanPuzzle>().isActive = true;
        GameObject.Find("PuzzleObject4").GetComponent<TrashCanPuzzle>().isActive = true;
        GameObject.Find("PuzzleObject5").GetComponent<TrashCanPuzzle>().isActive = true;
        isSolved = true;
    }

}