using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpPower = 5f;

    private Rigidbody rb;
    private bool isGrounded2 = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded2)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isGrounded2 = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded2 = true;
        }
    }
}
