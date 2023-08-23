using UnityEngine;

namespace KamooTutor
{

public class DragCameraWithMouse : MonoBehaviour
{
    public float sensitivity = 2.0f;  // Sensitivity of camera movement
    public float minY = 0.0f;         // Minimum Y position for the camera

    private bool isDragging = false;
    private Vector3 lastMousePosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Check if left mouse button is pressed
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))  // Check if left mouse button is released
        {
            isDragging = false;
        }

        if (isDragging)
        {
            // Calculate mouse movement delta
            Vector3 mouseDelta = lastMousePosition - Input.mousePosition;

            // Calculate new camera position
            Vector3 newPosition = transform.position;
            newPosition += transform.right * mouseDelta.x * sensitivity;
            newPosition += transform.forward * mouseDelta.y * sensitivity;

            // Ensure the camera doesn't move below the minimum Y position
            newPosition.y = transform.position.y;

            // Apply the new camera position
            transform.position = newPosition;

            // Update last mouse position for the next frame
            lastMousePosition = Input.mousePosition;
        }

        if(transform.position.z >= 32) transform.position = new Vector3(transform.position.x, transform.position.y, 32);
        
        if(transform.position.z <= -50) transform.position = new Vector3(transform.position.x, transform.position.y, -50);

        if(transform.position.x <= -30.5) transform.position = new Vector3(-30.5f, transform.position.y, transform.position.z);

        if(transform.position.x >= 84) transform.position = new Vector3(84, transform.position.y, transform.position.z);


    }
}

}
