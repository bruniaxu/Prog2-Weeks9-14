using UnityEngine;

public class ShrineEffectTest : MonoBehaviour
{
    public SpriteRenderer playerRenderer;

    //Sprites for the four elemental forms
    public Sprite fireSprite;
    public Sprite waterSprite;
    public Sprite natureSprite;
    public Sprite lightSprite;

    //Called by the Fire Shrine UnityEvent
    public void FireEffect()
    {
        playerRenderer.sprite = fireSprite;
        Debug.Log("Fire form activated!");
    }

    //Called by the Water Shrine UnityEvent
    public void WaterEffect()
    {
        playerRenderer.sprite = waterSprite;
        Debug.Log("Water form activated!");
    }

    //Called by the Nature Shrine UnityEvent
    public void NatureEffect()
    {
        playerRenderer.sprite = natureSprite;
        Debug.Log("Nature form activated!");
    }

    //Called by the Light Shrine UnityEvent
    public void LightEffect()
    {
        playerRenderer.sprite = lightSprite;
        Debug.Log("Light form activated!");
    }
}