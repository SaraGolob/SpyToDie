using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : MonoBehaviour
{

    public bool isActive;

    public Sprite activated, deactivated;

    public SpriteRenderer spriteRenderer;



    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            spriteRenderer.sprite = activated;

        }
        else
        {
            spriteRenderer.sprite = deactivated;
        }
    }

    public void ChangeState()
    {
        if (!CheckPuzzle.isSolved)
        {
            isActive = !isActive;
        }
    }
}
