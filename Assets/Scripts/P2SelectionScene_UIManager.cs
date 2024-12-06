using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using NUnit.Framework.Constraints;

public class P2SelectionScene_UIManager : MonoBehaviour
{
    public Button char1_Button;
    public Button char2_Button;
    public 

    void Start()
    {
        if(GameManager.p1SelectedCharacter != 0){
            char1_Button.onClick.AddListener(()=> onButtonClick(0));
        }
        else{
            char1_Button.interactable = false;
            char1_Button.targetGraphic.CrossFadeAlpha(0.2f, 0, false);
        }

        if(GameManager.p1SelectedCharacter != 1){
            char2_Button.onClick.AddListener(()=> onButtonClick(1));
        }
        else{
            char2_Button.interactable = false;
            char2_Button.targetGraphic.CrossFadeAlpha(0.2f, 0, false);
        }
        
    }

    void onButtonClick(int index){
        Debug.Log($"Button: Player 2 clicked char {index+1}");
        GameManager.selectCharacter(2, index);
        SceneManager.LoadScene("MapSelectionScene");
    }
}
