using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 8f;

    private Vector2 moveInput;

    // Called by the Input System (SendMessage)
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        // Movement
        Vector2 direction = moveInput.normalized;
        transform.position += (Vector3)(direction * moveSpeed * Time.deltaTime);

        // Rotation toward mouse
        RotateTowardMouse();
    }

    void RotateTowardMouse()
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 lookDir = mouseWorld - transform.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        // Subtract 90 if your triangle points "up" instead of "right"
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}