using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string HorizontalAxis = "Horizontal";
    [SerializeField] private string VerticalAxis = "Vertical";
    void Update()
    {
        var horizontal = Input.GetAxis(HorizontalAxis);
        var vertical = Input.GetAxis(VerticalAxis);
    }
}
