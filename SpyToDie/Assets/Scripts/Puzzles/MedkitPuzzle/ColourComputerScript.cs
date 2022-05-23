using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using SColor = System.Drawing.Color;
public class ColourComputerScript : MonoBehaviour
{
    public static bool isSolved;
    List<string> enteredColours;
    List<string> correctColours;
    List<SColor> sColours;

    [Header("Images")]
    public Image box1, box2, box3, box4, box5, box6;

    [Header("Event")]
    public UnityEvent simpleEvent;

    // Start is called before the first frame update
    void Start()
    {
        sColours = new List<SColor>();
        enteredColours = new List<string>();
        correctColours = new List<string>
        {
            "GREEN",
            "CYAN",
            "GREEN",
            "CYAN",
            "CYAN",
            "RED"
        };
        isSolved = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSolved)
        {
            ReadColours();
            AssignColours();
            CheckIfCorrect();
        }
    }

    public void AddToList(string colour)
    {
        enteredColours.Add(colour);
    }

    void ReadColours()
    {
        sColours.Clear(); //clears all colours
        for (int i = 0; i < 6; i++)
        {
            sColours.Add(SColor.FromName("WHITE")); //replace all colours with white
        }

        for (int i = 0; i < enteredColours.Count; i++)
        {
            sColours[i] = SColor.FromName(enteredColours[i]); //replace the white with entered colours
        }
    }

    void AssignColours()
    {
        box1.color = new Color(sColours[0].R, sColours[0].G, sColours[0].B);
        box2.color = new Color(sColours[1].R, sColours[1].G, sColours[1].B);
        box3.color = new Color(sColours[2].R, sColours[2].G, sColours[2].B);
        box4.color = new Color(sColours[3].R, sColours[3].G, sColours[3].B);
        box5.color = new Color(sColours[4].R, sColours[4].G, sColours[4].B);
        box6.color = new Color(sColours[5].R, sColours[5].G, sColours[5].B);


    }
    void CheckIfCorrect()
    {
        if (enteredColours.Count == 6)
        {
            if (Enumerable.SequenceEqual(enteredColours, correctColours))
            {
                isSolved = true;
                FindObjectOfType<AudioManager>().Play("PuzzleCompleted");
                simpleEvent.Invoke();
            }
            else
            {
                enteredColours.Clear();
            }
        }
    }
}
