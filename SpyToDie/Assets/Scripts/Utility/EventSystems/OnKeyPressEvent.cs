using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnKeyPressEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent OnKeyEvent;
    public KeyCode keyToPress;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && !PauseMenuScript.isPaused )
        {
            OnKeyEvent?.Invoke();
        }
    }
}
