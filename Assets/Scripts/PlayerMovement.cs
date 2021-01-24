using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 50f;
    private Rigidbody body;

    private bool IsMoving = false;

    private Vector3 destination;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        PlayerInput.OnInput += MovePlayer;
    }
    private void MovePlayer(Vector3 input)
    {
        //Debug.Log(input);
        //Debug.LogWarning(transform.position);
        body.AddForce(input, ForceMode.VelocityChange);
        transform.LookAt(input + transform.position);
        body.velocity = Vector3.ClampMagnitude(input, maxSpeed);

    }

    //private void MovePlayer(Vector3 input)
    //{
    //    moveDirection.Set(input.x, 0, input.z);

    //    body.AddForce(moveDirection * moveSpeedMultiplier);

    //    isMoved = true;
    //}

    //void FixedUpdate()
    //{


    //    if (isMoved) return;

    //    body.velocity = new Vector3(body.velocity.x * DragPercentSlowdown,
    //    body.velocity.y,
    //    body.velocity.z * DragPercentSlowdown);

    //}
}