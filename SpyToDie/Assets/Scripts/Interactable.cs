using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactEvent;
    public SpriteRenderer spriteItem;
    public SpriteRenderer SpriteRendDoor;
    public Sprite doorSprite;
    public GameObject popUp;
    public GameObject door;
    public BoxCollider2D doorCollid;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                popUp.SetActive(true);
                spriteItem.color = Color.black;
                interactEvent.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteItem.color = Color.blue;
            isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.gameObject.CompareTag("Player"))
        {
            spriteItem.color = Color.white;
            isInRange = false;
        }
    }

    public void PopDown()
    {
        popUp.SetActive(false);
        spriteItem .color = Color.green;
        doorCollid.enabled = false;
        SpriteRendDoor.sprite = doorSprite;
    }
}
