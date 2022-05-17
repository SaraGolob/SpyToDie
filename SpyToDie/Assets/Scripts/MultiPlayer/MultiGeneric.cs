using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiGeneric : MultiInteract
{
    // Start is called before the first frame update
    public UnityEvent simpleEvent;
    public override void Interact()
    {
        simpleEvent?.Invoke();
    }
}
