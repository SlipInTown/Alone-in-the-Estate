using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float maxSpeed = 50f;
    private Rigidbody body;

    [SerializeField] private Animator animatorController;

    [SerializeField] private bool isMoving;

    [SerializeField] private Rigidbody[] AllRigidbodys;

    [SerializeField] private string Idle = "Idle";
    [SerializeField] private string WalkingBackWard = "WalkingBackWard";
    [SerializeField] private string WalkingForward = "WalkingForward";
    void Awake()
    {
        animatorController = GetComponent<Animator>();
        for (int i = 0; i < AllRigidbodys.Length; i++)
        {
            AllRigidbodys[i].isKinematic = true;
        }
    }
    public void MovePlayer(float horizontalMove, float verticalMove)
    {
        //Debug.LogWarning($"{horizontalMove}, {verticalMove}");
        //Debug.Log($"quaternion = {quaternion} || vector = {vector}");
        //body.AddForce(vector, ForceMode.VelocityChange);
        //body.velocity = Vector3.ClampMagnitude(vector, maxSpeed);
        //transform.rotation = quaternion;
        if (verticalMove != 0)
        {
            if (verticalMove < 0)
            {
                animatorController.Play(WalkingBackWard);
            }
            else
            {
                animatorController.Play(WalkingForward);
            }
        }
        else
        {
            animatorController.Play(Idle);
        }
        transform.Rotate(0, horizontalMove, 0);
        transform.Translate(0, 0, verticalMove);
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