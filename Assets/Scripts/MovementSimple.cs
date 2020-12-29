using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSimple : MonoBehaviour
{
    [SerializeField] private float speed; // Скорость движения, а в дальнейшем ускорение
    private Rigidbody body;
    [SerializeField] private float rotationSpeed;
    private float vertical;
    private float horizontal;
    // Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }


    void OnMouseDown()
    {
        print("You clicked the John Lemon!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
        transform.Rotate((transform.up * horizontal) * rotationSpeed * Time.fixedDeltaTime);
        //body.MovePosition()
    }
}
