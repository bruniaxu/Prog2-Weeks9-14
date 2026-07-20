using UnityEngine;
using UnityEngine.InputSystem;

public class LookDirection : MonoBehaviour
{
    private Vector2 lookDirection = Vector2.right;

    public void OnLook(InputAction.CallbackContext context)
    {
        lookDirection = context.ReadValue<Vector2>();

        if (lookDirection != Vector2.zero)
        {
            transform.right = lookDirection;
        }
    }
}
