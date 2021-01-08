using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeedMultiplier = 5f;

    [SerializeField,Range(0.0f,1f)] private float dragPercentSlowdown = 0.01f;

    private Vector3 moveDirection;

    public float DragPercentSlowdown => (1 - dragPercentSlowdown);

    private Rigidbody body;

    private bool isMoved = false;

    void Start ()
    {
        body = GetComponent<Rigidbody>();
        PlayerInput.OnInput += MovePlayer; 
    }

    private void MovePlayer(Vector3 input)
    {
        moveDirection.Set(input.x, 0, input.z);

        body.AddForce(moveDirection * moveSpeedMultiplier);

        //body.MovePosition(new Vector3(0, input.y, 0));

        isMoved = true;
    }

    void FixedUpdate()
    {
        transform.LookAt(moveDirection + transform.position);

        if (isMoved) return;

        body.velocity = new Vector3(body.velocity.x * DragPercentSlowdown,
        body.velocity.y,
        body.velocity.z * DragPercentSlowdown); 
        
    }

    private void LateUpdate()
    {
        if (moveDirection == Vector3.zero)
        {
            isMoved = false;
        }
    }
}