using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MultiMovement : MonoBehaviour
{

    [Header("Animation")]
    public Rigidbody2D rigidBody2D;
    public Animator animator;
    [Header("Movement")]
    [Tooltip("this controlls the speed of the character")] public float movementSpeed;
    
    public Tilemap obstacles;
    public bool PauseMovement { get; set; }


    private Vector2 movement;
    private Vector2 movementThisFrame;
    private Vector2 oldLocation;

    private void Update() //inputs
    {
        if (PauseMovement)
        {
            movement = Vector2.zero;
        }
        else
        {
            movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //gets inputs
        }
    }
    private void FixedUpdate() //physics (updates at the constant speed)
    {
        movementThisFrame = movement.normalized * movementSpeed * Time.deltaTime; //time.deltatime is time between two fixed updates (frames), movement.normalized normalizes the speed so we always move at the same speed
        oldLocation = rigidBody2D.position; //save old position
        PlayerAnimation();
        rigidBody2D.MovePosition(oldLocation + movementThisFrame); //moves the player
    }
    private void PlayerAnimation()
    {
        if (movement != Vector2.zero) //animation
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("inputX", movement.x);
            animator.SetFloat("inputY", movement.y);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

}
