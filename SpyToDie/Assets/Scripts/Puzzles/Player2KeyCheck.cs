using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2KeyCheck : MonoBehaviour
{
    public bool HasKey { get; set; }

    public GameObject doorOpen,doorClose;
    

    // Update is called once per frame
    public void CheckKey()
    {
        if (HasKey)
        {
            doorClose.SetActive(false);
            doorOpen.SetActive(true);
        }        
    }
}
