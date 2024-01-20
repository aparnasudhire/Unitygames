using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // Reference to the player's transform.
    public float smoothSpeed = 2.0f; // Adjust this value to control the camera's smoothness.

    private Vector3 offset; // Offset to maintain the original Y position of the camera.

    private void Start()
    {
        // Calculate and store the initial offset between the camera and the player's position.
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        // Calculate the target position for the camera.
        Vector3 targetPosition = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);

        // Use SmoothDamp to smoothly move the camera to the target position.
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}


