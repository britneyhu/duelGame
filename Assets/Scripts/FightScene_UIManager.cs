using NUnit.Framework;
using UnityEngine;

public class FightScene_UIManager : MonoBehaviour
{
    public SpriteRenderer mapSprite; 
    public SpriteRenderer platformSprite;
    public SpriteRenderer player1Sprite;
    public SpriteRenderer player2Sprite;
    public Texture2D[] maps;
    public Texture2D[] platforms;
    public Texture2D[] characterSkins;

    void Start()
    {
        loadMap(GameManager.selectedMap);
        loadPlayers(GameManager.p1.index, GameManager.p2.index);
        Debug.Log($"p1 size {player1Sprite.size}");
    }

    void Update()
    {
        if(GameManager.p1.currentHealth == 0){
            GameManager.winner = 2;
            //stop game and show winner screen
        }

        if(GameManager.p2.currentHealth == 0){
            GameManager.winner = 1;
        }
    }

    void loadMap(int mapIndex)
    {
        // Get the texture at the specified index
        Texture2D selectedMap = maps[mapIndex];

        // Convert the Texture2D into a Sprite
        Sprite newMapSprite = Sprite.Create(
            selectedMap, 
            new Rect(0, 0, selectedMap.width, selectedMap.height), 
            new Vector2(0.5f, 0.5f) // Pivot at the center
        );

        // Assign the new sprite to the SpriteRenderer
        mapSprite.sprite = newMapSprite;

        Texture2D selectedPlatform = platforms[mapIndex];

        Sprite newPlatformSprite = Sprite.Create(
            selectedPlatform, 
            new Rect(0, 0, selectedPlatform.width, selectedPlatform.height), 
            new Vector2(0.5f, 0.5f)
        );

        platformSprite.sprite = newPlatformSprite;
    }

    void loadPlayers(int p1Index, int p2Index)
    {
        Texture2D p1SelectedChar = characterSkins[p1Index];

        Sprite newP1Sprite = Sprite.Create(
            p1SelectedChar, 
            new Rect(0, 0, p1SelectedChar.width, p1SelectedChar.height), 
            new Vector2(0.5f, 0.5f)
        );

        player1Sprite.sprite = newP1Sprite;        

        Texture2D p2SelectedChar = characterSkins[p2Index];

        Sprite newP2Sprite = Sprite.Create(
            p2SelectedChar, 
            new Rect(0, 0, p2SelectedChar.width, p2SelectedChar.height), 
            new Vector2(0.5f, 0.5f)
        );

        player2Sprite.sprite = newP2Sprite;
    }
}
