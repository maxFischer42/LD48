using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ControllerComponent;

public class TopDownCharacterController : Controller
{
    public float moveSpeed = 0.1f;
    private float transitionSpeed = 0.1f;

    // Note, make omnidirectional movement

    // check current input direction

    // ensure the current direction is valid

    public void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Vector2 inputDirection = getMovementAxisRaw(); // Get the movement inputs to a magnitude of 1
        if(getRayToDirection2D(inputDirection)) { return; }
        transform.position = Vector2.Lerp(transform.position, (Vector2)transform.position + (inputDirection * moveSpeed), Time.deltaTime * transitionSpeed);
    }



}
