using System.Collections;
using UnityEngine;

public class CreatureEffects : MonoBehaviour
{
    public SpriteRenderer playerRenderer;

    // Normal player sprite
    public Sprite normalSprite;

    // Elemental sprites
    public Sprite fireSprite;
    public Sprite waterSprite;
    public Sprite natureSprite;
    public Sprite lightSprite;

    // How long the elemental form lasts
    public float effectDuration = 5f;

    // Store the current effect
    private Coroutine currentEffect;

    void Start()
    {
        // Store the player's starting sprite
        normalSprite = playerRenderer.sprite;
    }

    public void FireEffect()
    {
        StartElementEffect(fireSprite);
    }

    public void WaterEffect()
    {
        StartElementEffect(waterSprite);
    }

    public void NatureEffect()
    {
        StartElementEffect(natureSprite);
    }

    public void LightEffect()
    {
        StartElementEffect(lightSprite);
    }

    void StartElementEffect(Sprite elementalSprite)
    {
        // Stop the old effect if another shrine is activated
        if (currentEffect != null)
        {
            StopCoroutine(currentEffect);
        }

        // Start the new elemental effect
        currentEffect = StartCoroutine(ElementEffect(elementalSprite));
    }

    IEnumerator ElementEffect(Sprite elementalSprite)
    {
        // Change into the elemental form
        playerRenderer.sprite = elementalSprite;

        // Keep the form active for the effect duration
        yield return new WaitForSeconds(effectDuration);

        // Return to the normal form
        playerRenderer.sprite = normalSprite;

        currentEffect = null;
    }
}