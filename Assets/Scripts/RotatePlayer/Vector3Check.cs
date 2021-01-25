using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Check : MonoBehaviour
{
    public InputEvent onSecondInputVector3;
    public InputEvent onThirdInputVector3;

    private Vector3 lastInput;

    public void IsMoveForward(Vector3 input)
    {
        if (lastInput == input) onSecondInputVector3?.Invoke(input);
        else onThirdInputVector3?.Invoke(input);

        //transform.eulerAngles = input;

        //transform.LookAt(input + transform.position);
        //создать переменную для сохранения последней позиции чтобы не делать два раза rotation
        lastInput = input;
    }
}
