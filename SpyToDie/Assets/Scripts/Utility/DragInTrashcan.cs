using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragInTrashcan : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("OnPointerDown");
    }
}
