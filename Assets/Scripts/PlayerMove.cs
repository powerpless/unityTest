using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float shiftSpeed = 1.1f;
    private float currentSpeed;
    private Rigidbody rb;
    private Vector3 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        moveInput = transform.right * moveHorizontal + transform.forward * moveVertical;
        
        if(Input.GetKey(KeyCode.LeftShift))
            currentSpeed = speed  * shiftSpeed;
        else
            currentSpeed = speed;
    }

    void FixedUpdate()
    {
        Vector3 velocity = moveInput * currentSpeed;
        velocity.y = rb.linearVelocity.y;
        rb.linearVelocity = velocity;
    }
}
