using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Animation")]
    public Rigidbody2D rigidBody2D;
    public Animator animator;
    [Header("Movement")]
    [Tooltip("this controlls the speed of the character")] public float movementSpeed;
    //[SerializeField] if you want private to show in inspector
    //[HideInInspector] if you want public not to show in inspector
    //[System.Serializable] enums or class to be shown in inspector
    private Vector2 movement;
    private Vector2 movementThisFrame;
    private Vector2 oldLocation;

    private void Update() //inputs
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //gets inputs
    }
    private void FixedUpdate() //physics (updates at the constant speed)
    {
        movementThisFrame = movement.normalized * movementSpeed * Time.deltaTime; //time.deltatime is time between two fixed updates (frames), movement.normalized normalizes the speed so we always move at the same speed
        oldLocation = rigidBody2D.position; //save old position

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


        rigidBody2D.MovePosition(oldLocation + movementThisFrame); //moves the player
    }
}
