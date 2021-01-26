using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Check : MonoBehaviour
{
    public Vector3Event fromCheckToMove;

    public void IsMoveForward(float horizontalMove, float verticalMove)
    {
        //if (lastInput == input) fromCheckToMove?.Invoke(input);
        //else 
        fromCheckToMove?.Invoke(horizontalMove, verticalMove);

        //transform.eulerAngles = input;

        //transform.LookAt(input + transform.position);
        //создать переменную для сохранения последней позиции чтобы не делать два раза rotation
        //lastInput = input;
    }
}
