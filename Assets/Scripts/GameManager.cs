using UnityEngine;

public static class GameManager
{
    public static characterTemplate p1;
    public static characterTemplate p2;
    public static characterTemplate[] characters = new characterTemplate[2];

    public static int selectedMap;

    public static int winner;
    

	public static void InitGame()
	{
        characters[0] = new characterTemplate{index = 0, charName = "char1", maxHealth = 100f, maxSpeed = 4f, maxJump = 5f, ability1 = "ability1", ability2 = "ability2", ult = "ult", currentHealth = 100f};
        characters[1] = new characterTemplate{index = 1, charName = "char2", maxHealth = 80f, maxSpeed = 6f, maxJump = 8f, ability1 = "ability1", ability2 = "ability2", ult = "ult", currentHealth = 100f};

        Debug.Log($"GameManager Initialized, Characters: {characters.Length}");
	}
	
	
    public static void selectCharacter(int player, int index){
        if(player == 1){
            p1 = characters[index];
            Debug.Log($"Game Manager: Player 1 selected character: {p1}");
        }
        else{
            p2 = characters[index];
            Debug.Log($"Game Manager: Player 2 selected character: {p2}");
        }
        
    }

    public static void selectMap(int index)
    {
        selectedMap = index;

        Debug.Log($"Game Manager: Player selected map: {selectedMap}");
    }
}
