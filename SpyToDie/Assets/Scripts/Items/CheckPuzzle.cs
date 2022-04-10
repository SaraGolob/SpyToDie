using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckPuzzle : MonoBehaviour
{
    public UnityEvent simpleEvent;
    public bool puzzleObject1, puzzleObject2, puzzleObject3, puzzleObject4, puzzleObject5;
    bool isSolved;

    void Update()
    {
        puzzleObject1 = GameObject.Find("PuzzleObject1").GetComponent<LightPuzzle>().isActive;
        puzzleObject2 = GameObject.Find("PuzzleObject2").GetComponent<LightPuzzle>().isActive;
        puzzleObject3 = GameObject.Find("PuzzleObject3").GetComponent<LightPuzzle>().isActive;
        puzzleObject4 = GameObject.Find("PuzzleObject4").GetComponent<LightPuzzle>().isActive;
        puzzleObject5 = GameObject.Find("PuzzleObject5").GetComponent<LightPuzzle>().isActive;

        if (puzzleObject1 && puzzleObject2 && puzzleObject3 && puzzleObject4 && puzzleObject5)
        {
            simpleEvent.Invoke();
        }
    }
}