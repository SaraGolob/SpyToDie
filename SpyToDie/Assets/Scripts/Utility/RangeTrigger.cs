using UnityEngine;
using UnityEngine.Events;

public class RangeTrigger : MonoBehaviour
{
    public float interactRange = 1f;
    public Vector2 offset;
    public int repeatThis = 0;
    public UnityEvent simpleEvent;


    public void Update() //does similar thing to generic interact script except it triggers the event as soon as someone enters certain range
    {
        if (repeatThis >= 0)
        {
            if ((((Vector2)transform.position + offset) - (Vector2)References.instance.playerTransform.position).sqrMagnitude < interactRange * interactRange) //bunch of math, basically checks if player is inside range
            {
                Interact();
                repeatThis--;
            }
        }
    }
    public void Interact()
    {
        simpleEvent?.Invoke();
    }
    private void OnDrawGizmosSelected() //draws the range in the scene view so you can visualize it easier
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + (Vector3)offset, interactRange);
    }
}
