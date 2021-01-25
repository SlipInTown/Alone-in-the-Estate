using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Rotate : MonoBehaviour
{
    public InputEvent onFourthInputVector3;

    [SerializeField,Range(0f,1f)] private float quaternionFloat;

    public void RotatePlayer(Vector3 vector)
    {
        Quaternion.Lerp(transform.rotation, Quaternion.Euler(vector), quaternionFloat);

        onFourthInputVector3?.Invoke(vector);
    }
}
