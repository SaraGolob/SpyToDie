using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidBody;
    public Animator animator;
    public Tilemap obstacles;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Update is called 50 times per second
    void FixedUpdate()
    {
        // Movement
        Vector3Int obstacleMapTile = obstacles.WorldToCell(rigidBody.position + (movement/2) - new Vector2(0, 0.5f));

        if (obstacles.GetTile(obstacleMapTile) == null)
        {
            rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(rigidBody.position + (movement/2) - new Vector2(0, 0.5f), 0.2f);
    }
}
