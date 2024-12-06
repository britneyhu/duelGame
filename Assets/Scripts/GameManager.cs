using UnityEngine;

public static class GameManager
{
    public static int p1SelectedCharacter;
    public static int p2SelectedCharacter;
    public static characterTemplate[] characters = new characterTemplate[2];

    public static int selectedMap;
    

	public static void InitGame()
	{
        characters[0] = new characterTemplate{charName = "char1", maxHealth = 100f, maxSpeed = 4f, maxJump = 5f, ability1 = "ability1", ability2 = "ability2", ult = "ult"};
        characters[1] = new characterTemplate{charName = "char2", maxHealth = 80f, maxSpeed = 6f, maxJump = 8f, ability1 = "ability1", ability2 = "ability2", ult = "ult"};

        Debug.Log($"GameManager Initialized, Characters: {characters.Length}");
	}
	
	
    public static void selectCharacter(int player, int index){
        if(player == 1){
            p1SelectedCharacter = index;
            Debug.Log($"Game Manager: Player 1 selected character: {p1SelectedCharacter}");
        }
        else{
            p2SelectedCharacter = index;
            Debug.Log($"Game Manager: Player 2 selected character: {p2SelectedCharacter}");
        }
        
    }

    public static void selectMap(int index)
    {
        selectedMap = index;

        Debug.Log($"Game Manager: Player selected map: {selectedMap}");
    }
}
