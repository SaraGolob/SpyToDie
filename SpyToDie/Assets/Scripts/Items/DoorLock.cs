using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite doorClosed, doorOpened;
    public bool doorLocked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorLocked)
        {
            spriteRenderer.sprite = doorClosed;
        }
        else
        {
            spriteRenderer.sprite = doorOpened;
        }
    }
}
