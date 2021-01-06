using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string horizontalAxis = "Horizontal";
    [SerializeField] private string verticalAxis = "Vertical";

    private Vector3 inputAxis;

    //public UnityEvent<Vector3> OnInputEvent;

    public static Action<Vector3> OnInput;
    void FixedUpdate()
    {
        var horizontal = Input.GetAxis(horizontalAxis);
        var vertical = Input.GetAxis(verticalAxis);

        inputAxis.Set(horizontal, 0, vertical);

        OnInput?.Invoke(inputAxis);
    }
}

//[Serializable]
//public struct InputAxis
//{
//    public Vector3 input;
//}