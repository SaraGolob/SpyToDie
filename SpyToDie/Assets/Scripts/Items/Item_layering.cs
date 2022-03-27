using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_layering : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position.y < References.instance.playerTransform.position.y)
        {
            spriteRenderer.sortingLayerName = "Foreground";
        }
        else
        {
            spriteRenderer.sortingLayerName = "Background";
        }
    }
}
