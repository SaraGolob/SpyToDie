using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable_Door : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactEvent;
    public SpriteRenderer spriteItem;

  
    public GameObject popUp;
    [Header("Door")]
    public GameObject door;
    public BoxCollider2D doorCollid;
    public SpriteRenderer doorSpriteRenderer;
    public Sprite doorClosed, doorOpened;
    public bool doorLocked;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorLock();
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
        doorLocked= false;
       
    }
    private void DoorLock()
    {
        if (doorLocked)
        {
            doorCollid.enabled = true;
            doorSpriteRenderer.sprite = doorClosed;
        }
        else
        {
            doorCollid.enabled = false;
            doorSpriteRenderer.sprite = doorOpened;
        }
    }
}
