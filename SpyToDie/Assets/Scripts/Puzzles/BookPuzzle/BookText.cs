using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SColor = System.Drawing.Color;

public class BookText : MonoBehaviour
{
    [Header("Colours")]
    public static string colour1 = "yellow";
    private SColor sColour1;
    public static string colour2 = "magenta";
    private SColor sColour2;
    public static string colour3 = "red";
    private SColor sColour3;
    public static string colour4 = "green";
    private SColor sColour4;

    [Header("TMP Text")]
    public TMP_Text storyText;

    [Header("Images")]

    public Image bottle1;
    public Image bottle2;
    public Image bottle3;
    public Image bottle4;

    private void Start()
    {
        storyText.text = "To create the secret formula, first add 50ml of the " + colour1 + " hydrochloric acid, then 80ml of the " + colour2 + " cadmium cyanide solution and a single drop from the "
        + colour3 + " diisodecyl phthalate. The final ingredient is to add 32.71ml of the " + colour4 + " ammonium hydroxide.";

        sColour1 = SColor.FromName(colour1);
        sColour2 = SColor.FromName(colour2);
        sColour3 = SColor.FromName(colour3);
        sColour4 = SColor.FromName(colour4);

        bottle1.color = new Color(sColour1.R, sColour1.G, sColour1.B);
        bottle2.color = new Color(sColour2.R, sColour2.G, sColour2.B);
        bottle3.color = new Color(sColour3.R, sColour3.G, sColour3.B);
        bottle4.color = new Color(sColour4.R, sColour4.G, sColour4.B);
    }
}