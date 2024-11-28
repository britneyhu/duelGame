using UnityEngine;

public static class GameManager
{
    public static characterTemplate p1SelectedCharacter;
    public static characterTemplate p2SelectedCharacter;
    public static characterTemplate[] characters = new characterTemplate[2];

	public static void InitGame()
	{
        characters[0] = new characterTemplate{charName = "char1", maxHealth = 100f, maxSpeed = 4f, maxJump = 5f, ability1 = "ability1", ability2 = "ability2", ult = "ult"};
        characters[1] = new characterTemplate{charName = "char2", maxHealth = 80f, maxSpeed = 6f, maxJump = 8f, ability1 = "ability1", ability2 = "ability2", ult = "ult"};

        Debug.Log($"GameManager Initialized, Characters: {characters.Length}");
	}
	
	
    public static void selectCharacter(int player, int index){
        if(player == 1){
            p1SelectedCharacter = characters[index];
            Debug.Log($"Game Manager: Player 1 selected character: {p1SelectedCharacter.charName}");
        }
        else{
            p2SelectedCharacter = characters[index];
            Debug.Log($"Game Manager: Player 2 selected character: {p2SelectedCharacter.charName}");
        }
        
    }
}
