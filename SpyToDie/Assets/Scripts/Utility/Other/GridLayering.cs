using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridLayering : MonoBehaviour
{
    // Start is called before the first frame update
    private TilemapRenderer tileRenderer;


    void Start()
    {
        tileRenderer = GetComponent<TilemapRenderer>();
    }

    void Update()
    {
        if (GameManager.instance.players[0] == true)
        {
            if (transform.position.y < GameManager.instance.players[0].transform.transform.position.y)
            {
                tileRenderer.sortingLayerName = "Foreground";
            }
            else
            {
                tileRenderer.sortingLayerName = "Background";
            }
        }
        else if (GameManager.instance.players[1] == true)
            if (transform.position.y < GameManager.instance.players[1].transform.transform.position.y)
            {
                tileRenderer.sortingLayerName = "Foreground";
            }
            else
            {
                tileRenderer.sortingLayerName = "Background";
            }
    }
}
