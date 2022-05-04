using UnityEngine;
using UnityEngine.Events;

public class GenericInteract : Interactable
{
    public UnityEvent simpleEvent;
    public override void Interact()
    {
        simpleEvent?.Invoke(); 
    }
}
