using UnityEngine;

public class FightScene_UIManager : MonoBehaviour
{
    public SpriteRenderer mapSprite; 
    public SpriteRenderer platformSprite;
    public Texture2D[] maps;
    public Texture2D[] platforms;

    void Start()
    {
        loadMap(GameManager.selectedMapIndex);
        loadPlatform(GameManager.selectedPlatformIndex);
    }

    void Update()
    {
        
    }

    void loadMap(int mapIndex)
    {
        // Get the texture at the specified index
        Texture2D selectedMap = maps[mapIndex];

        // Convert the Texture2D into a Sprite
        Sprite newSprite = Sprite.Create(
            selectedMap, 
            new Rect(0, 0, selectedMap.width, selectedMap.height), 
            new Vector2(0.5f, 0.5f) // Pivot at the center
        );

        // Assign the new sprite to the SpriteRenderer
        mapSprite.sprite = newSprite;
    }

    void loadPlatform(int platformIndex)
    {
        // Get the texture at the specified index
        Texture2D selectedPlatforms = platforms[platformIndex];

        // Convert the Texture2D into a Sprite
        Sprite newSprite = Sprite.Create(
            selectedPlatforms, 
            new Rect(0, 0, selectedPlatforms.width, selectedPlatforms.height), 
            new Vector2(0.5f, 0.5f) // Pivot at the center
        );

        // Assign the new sprite to the SpriteRenderer
        platformSprite.sprite = newSprite;
    }
}
