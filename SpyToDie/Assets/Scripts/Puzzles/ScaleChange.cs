using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public GameObject obj;
    private Vector3 oldPod = new Vector3(4, 4, 0);
    public void ChangeScale()
    {
        obj.transform.position = new Vector3(0, 0, 0);
        obj.transform.localScale = new Vector3(1, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
