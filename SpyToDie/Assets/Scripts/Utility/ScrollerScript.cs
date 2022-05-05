using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class ScrollerScript : MonoBehaviour
{
    [Header("Scrolling text:")]
    public TMP_Text text;
    [Header("Scrolling speed:")]
    public int scrollSpeed;
    [Header("Scrolling speed:")]
    public float scrollEdge;

    void Start()
    {
        scrollEdge = 540f + text.preferredHeight;
    }

    void Update()
    {
        text.transform.Translate(0, scrollSpeed, 0);

        if (text.transform.position.y > scrollEdge)
        {
            ResetScene();
        }
    }

    void ResetScene()
    {
        text.transform.position = new Vector3(0, -1100, 0);
        SceneManager.LoadScene("MainMenu");
    }
}
