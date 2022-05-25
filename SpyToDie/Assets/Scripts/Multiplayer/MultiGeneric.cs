using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiGeneric : MultiInteract
{
    public UnityEvent simpleEvent;
    public override void Interact()
    {
        simpleEvent?.Invoke();
    }
}
