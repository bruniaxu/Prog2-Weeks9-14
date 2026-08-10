using UnityEngine;
using UnityEngine.Events;

public class Shrine : MonoBehaviour
{

    //References needed to check if the player is near the shrine
    public Transform player;
    public SpriteRenderer sensor;
    public PlayerInteraction playerInteraction;

    //Event that happens when the shrine is activated
    public UnityEvent OnShrineActivated;

    //Store if the player is inside the shrine sensor area
    public bool playerNearby = false;

    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the player's position is inside the sensor bounds
        playerNearby = sensor.bounds.Contains(player.position);

        //If player is inside the sensor, store this shrine as nearby
        if (playerNearby)
        {
            playerInteraction.nearbyShrine = this;
        }
        else
        {
            //Only remove the shrine if this is the currently stored shrine
            if (playerInteraction.nearbyShrine == this)
            {
                playerInteraction.nearbyShrine = null;
            }
        }
    }

    //Called when the player presses the interact button
    public void ActivateShrine()
    {
        //Only activate if the player is near the shrine
        if (playerNearby)
        {
            //Raise the shrine event
            OnShrineActivated.Invoke();
            Debug.Log("Shrine Activated!");
        }
    }
}
