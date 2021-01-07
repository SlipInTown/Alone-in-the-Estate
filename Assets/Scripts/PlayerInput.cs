using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string horizontalAxis = "Horizontal";
    [SerializeField] private string verticalAxis = "Vertical";
    [SerializeField] private string jumpAxis = "Jump";

    private Vector3 inputAxis;

    //public UnityEvent<Vector3> OnInputEvent;

    public static Action<Vector3> OnInput;
    public static Action<bool> MouseZeroInput;
    void FixedUpdate()
    {
        var horizontal = Input.GetAxis(horizontalAxis);
        var vertical = Input.GetAxis(verticalAxis);
        //var jump = Input.GetAxis(jumpAxis);

        inputAxis.Set(horizontal, 0, vertical);

        OnInput?.Invoke(inputAxis);
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