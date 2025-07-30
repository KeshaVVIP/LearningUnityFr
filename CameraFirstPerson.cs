using UnityEngine;

public class CameraFirstPerson : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;

    private float yRotation = 0f;
    private float xRotation = 0f;

    public void Start()
    {
        // Lock the cursor to the center of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;
    }
}
