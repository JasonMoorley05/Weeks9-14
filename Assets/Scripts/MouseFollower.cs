using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = context.ReadValue<Vector2>();

        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(mousePosition);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 mouseMovement = context.ReadValue<Vector2>();

        if (mouseMovement.x != 0 && mouseMovement.y != 0)
        {
            transform.up = mouseMovement;
        }
    }
}
