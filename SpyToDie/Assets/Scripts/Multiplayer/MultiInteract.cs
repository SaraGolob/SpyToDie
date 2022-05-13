using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiInteract : MonoBehaviour
{
    public float interactRange = 1f;
    public Vector2 offset;
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !PauseMenuScript.isPaused) //checks if player is pressing the button
        {
            if ((((Vector2)transform.position + offset) - (Vector2)GameManager.instance.players[0].transform.position).sqrMagnitude < interactRange * interactRange)
            //bunch of math, basically checks if player is inside range
            {
                Interact();
            }
            else if((((Vector2)transform.position + offset) - (Vector2)GameManager.instance.players[1].transform.position).sqrMagnitude < interactRange * interactRange)
            {
                Interact();
            }
        }
    }
    public virtual void Interact() // this will be overridden
    {

    }
    private void OnDrawGizmosSelected() //draws the range in the scene view so you can visualize it easier
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + (Vector3)offset, interactRange);
    }
}
