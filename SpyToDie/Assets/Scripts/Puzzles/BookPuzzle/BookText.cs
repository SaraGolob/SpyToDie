using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SColor = System.Drawing.Color;

public class BookText : MonoBehaviour
{
    [Header("Colours")]
    public static string colour1 = "green";
    private SColor scolour1;
    public static string colour2 = "magenta";
    private SColor scolour2;
    public static string colour3 = "red";
    private SColor scolour3;
    public static string colour4 = "yellow";
    private SColor scolour4;

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

        scolour1 = SColor.FromName(colour1);
        scolour2 = SColor.FromName(colour2);
        scolour3 = SColor.FromName(colour3);
        scolour4 = SColor.FromName(colour4);

        bottle1.color = new Color(scolour1.R, scolour1.G, scolour1.B);
        bottle2.color = new Color(scolour2.R, scolour2.G, scolour2.B);
        bottle3.color = new Color(scolour3.R, scolour3.G, scolour3.B);
        bottle4.color = new Color(scolour4.R, scolour4.G, scolour4.B);
    }
}