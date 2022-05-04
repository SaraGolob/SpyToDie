using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour
{
    public GameObject playerTransform;
    public static References instance;

    private void Start()
    {
        Debug.Log(instance.playerTransform.tag);
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }
    }
}
