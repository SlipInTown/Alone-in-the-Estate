using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeedMultiplier = 5f;

    private Vector3 moveDirection;

    private Rigidbody body;

    void Start ()
    {
        body = GetComponent<Rigidbody>();
        PlayerInput.OnInput += MovePlayer; 
    }

    private void MovePlayer(Vector3 input)
    {
        moveDirection.Set(input.x, 0, input.z);

        body.AddForce(moveDirection * moveSpeedMultiplier);
    }

    void FixedUpdate()
    {
        transform.LookAt(moveDirection + transform.position);
    }

    private void LateUpdate()
    {
        if (moveDirection == Vector3.zero)
        {
            body.velocity = Vector3.zero;
        }
    }
}