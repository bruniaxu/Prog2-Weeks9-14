using UnityEngine;

public class ShrineEffectTest : MonoBehaviour
{
    public SpriteRenderer playerRenderer;

    // Called by the shrine UnityEvent
    public void FireEffect()
    {
        // Change player colour to red
        playerRenderer.color = Color.red;

        Debug.Log("Fire effect activated!");
    }
}