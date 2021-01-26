using UnityEngine;
using UnityEngine.Events;

public class Vector3Rotate : MonoBehaviour
{
    //public QuatVectEvent fromRotateToMove;

    //private Quaternion rotation;

    //private Transform playerTransform;

    //[SerializeField,Range(0f,1f)] private float quaternionFloat;

    //private void Start()
    //{
    //    playerTransform = GetComponent<Transform>();
    //}
    //public void RotatePlayer(Vector3 vector)
    //{
        //Vector3 targetDir =  vector - transform.forward;
        //Debug.Log($" targetDir = {targetDir.normalized}");
        //float angle = Vector3.Angle(vector, transform.position.normalized);
        //Debug.Log($" angle = {angle}");
        //rotation = Quaternion.Slerp(playerTransform.rotation, Quaternion.Euler(0,angle,0), quaternionFloat);

        //Debug.Log($"{rotation} || {vector}");
        //fromRotateToMove?.Invoke(rotation, vector);
    //}
}
//[System.Serializable]
//public class QuatVectEvent : UnityEvent<Quaternion,Vector3> { }