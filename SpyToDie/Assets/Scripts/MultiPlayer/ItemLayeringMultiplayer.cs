using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ItemLayeringMultiplayer : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();       
    }

    void Update()
    {
        if (GameManager.instance.players[0] == true)
        {
            if (transform.position.y < GameManager.instance.players[0].transform.transform.position.y)
            {
                spriteRenderer.sortingLayerName = "Foreground";
            }
            else
            {
                spriteRenderer.sortingLayerName = "Background";
            }
        }
        else if(GameManager.instance.players[1] == true)
        if (transform.position.y < GameManager.instance.players[1].transform.transform.position.y)
        {
            spriteRenderer.sortingLayerName = "Foreground";
        }
        else
        {
            spriteRenderer.sortingLayerName = "Background";
        }
    }
}
