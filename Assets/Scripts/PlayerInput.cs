using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string horizontalAxis = "Horizontal";
    [SerializeField] private string verticalAxis = "Vertical";

    //[SerializeField] private float moveSpeedMultiplier = 5f;
        
    [SerializeField] private Camera mainCamera;
    public Vector3Event fromInputToCheck;

    private float horizontalMove;
    private float verticalMove;

    //private void Start()
    //{
    //    mainCamera = Camera.main;
    //}

    public BoolEvent MouseZeroInput;
    void FixedUpdate()
    {
        //Vector3 right = mainCamera.transform.right;

        //Vector3 forward = Vector3.Cross(right, Vector3.up);

        //Vector3 movement = Vector3.zero;

        //movement += right * Input.GetAxis(horizontalAxis) * Time.deltaTime * moveSpeedMultiplier;

        //movement += forward * Input.GetAxis(verticalAxis) * Time.deltaTime * moveSpeedMultiplier;

        //if (movement == Vector3.zero) return;

        //Debug.Log($"movement = {movement}");
        //if (movement == Vector3.zero) return;
        
        horizontalMove = Input.GetAxis(horizontalAxis) * Time.deltaTime * 150;
        verticalMove = Input.GetAxis(verticalAxis) * Time.deltaTime * 3.9f;
        fromInputToCheck?.Invoke(horizontalMove, verticalMove);
    }

    private void LateUpdate()
    {
        MouseZeroInput?.Invoke(Input.GetMouseButtonDown(0));
    }
}

[System.Serializable]
public class Vector3Event : UnityEvent<float,float>{ }
[System.Serializable]
public class BoolEvent : UnityEvent<bool> { }