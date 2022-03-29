using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactEvent;
    public SpriteRenderer sprite;
    public GameObject popUp;
    public GameObject door;

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
                sprite.color = Color.black;
                interactEvent.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sprite.color = Color.blue;
            isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.gameObject.CompareTag("Player"))
        {
            sprite.color = Color.white;
            isInRange = false;
        }
    }

    public void PopDown()
    {
        popUp.SetActive(false);
        sprite.color = Color.green;
        door.SetActive(false);
    }
}
