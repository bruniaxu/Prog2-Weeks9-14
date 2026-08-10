using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    // Store the shrine that the player is currently near
    public Shrine nearbyShrine;

    // Called by PlayerInput when the interact button is pressed
    public void OnInteract(InputAction.CallbackContext context)
    {
        // Only interact when the input is performed
        if (context.performed)
        {
            // Check if there is a shrine nearby
            if (nearbyShrine != null)
            {
                nearbyShrine.ActivateShrine();
                Debug.Log("Shrine interaction");
            }
        }
    }
}