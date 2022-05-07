using UnityEngine;

public class ItemLayering : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position.y < References.instance.playerTransform.transform.position.y)
        {
            spriteRenderer.sortingLayerName = "Foreground";
        }
        else
        {
            spriteRenderer.sortingLayerName = "Background";
        }
    }
}
