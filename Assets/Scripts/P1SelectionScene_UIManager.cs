using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionScene_UIManager : MonoBehaviour
{
    public Button char1_Button;
    public Button char2_Button;

    void Start()
    {
        char1_Button.onClick.AddListener(()=> onButtonClick(0));
        char2_Button.onClick.AddListener(()=> onButtonClick(1));
    }

    void onButtonClick(int index){
        GameManager.selectCharacter(1, index);
        Debug.Log($"Button: Player 1 clicked char {index+1}");
        // SceneManager.LoadScene("SelectionScene");
    }
}