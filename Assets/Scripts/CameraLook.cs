using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float sensitivity = 2f;
    [SerializeField] private Transform playerBody;
    private float verticalRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        
        playerBody.Rotate(Vector3.up * mouseX);
        
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
