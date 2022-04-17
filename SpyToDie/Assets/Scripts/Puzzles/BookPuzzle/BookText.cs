using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SColor = System.Drawing.Color;

public class BookText : MonoBehaviour
{
    [Header("Colors")]
    public static string color1 = "cyan";
    private SColor sColor1;
    public static string color2 = "magenta";
    private SColor sColor2;
    public static string color3 = "red";
    private SColor sColor3;
    public static string color4 = "blue";
    private SColor sColor4;

    [Header("TMP Text")]
    public TMP_Text storyText;

    [Header("Images")]
    public Image jacket;
    public Image jeans;
    public Image cap;
    public Image car;

    void Start()
    {
        storyText.text = "The suspect is a tall male last seen wearing a " + color1 + " jacket, " + color2 + " jeans and a "
        + color3 + " baseball cap. He was last seen leaving the scene of the crime in a " + color4 + " Ford Focus.";

        sColor1 = SColor.FromName(color1);
        sColor2 = SColor.FromName(color2);
        sColor3 = SColor.FromName(color3);
        sColor4 = SColor.FromName(color4);

        jacket.color = new Color(sColor1.R, sColor1.G, sColor1.B);
        jeans.color = new Color(sColor2.R, sColor2.G, sColor2.B);
        cap.color = new Color(sColor3.R, sColor3.G, sColor3.B); ;
        car.color = new Color(sColor4.R, sColor4.G, sColor4.B); ;
    }


}
