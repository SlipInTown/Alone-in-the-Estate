using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string horizontalAxis = "Horizontal";
    [SerializeField] private string verticalAxis = "Vertical";

    [SerializeField] private float moveSpeedMultiplier = 5f;

    [SerializeField] private Camera mainCamera;

    //private RayCast RayCast;

    public static Action<Vector3> OnInput;

    private void Awake()
    {
        mainCamera = Camera.main;

        //RayCast = GetComponentInChildren<RayCast>();
    }

    public static Action<bool> MouseZeroInput;
    void FixedUpdate()
    {
        Vector3 right = mainCamera.transform.right;

        Vector3 forward = Vector3.Cross(right, Vector3.up);

        Vector3 movement = Vector3.zero;

        movement += right * Input.GetAxis(horizontalAxis) * Time.deltaTime * moveSpeedMultiplier;

        movement += forward * Input.GetAxis(verticalAxis) * Time.deltaTime * moveSpeedMultiplier;
        
        OnInput?.Invoke(movement);
    }

    private void LateUpdate()
    {
        MouseZeroInput?.Invoke(Input.GetMouseButtonDown(0));
    }
}

//[Serializable]
//public struct InputAxis
//{
//    public Vector3 input;
//}