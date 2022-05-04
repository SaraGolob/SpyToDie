using UnityEngine;
using UnityEngine.Events;

public class Generic_interact : Interactable
{
    public UnityEvent simpleEvent;
    public override void Interact()
    {
        simpleEvent?.Invoke(); 
    }
}
