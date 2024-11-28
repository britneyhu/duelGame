using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene_UIManager : MonoBehaviour
{
    public Button startGame_button;

    void Start()
    {
        // GameManager.InitGame();
        
        startGame_button.onClick.AddListener(()=> onButtonClick(0));
    }

    void onButtonClick(int index){
        if(index == 0){
            Debug.Log($"Start Button Clicked, Index = {index}");
            SceneManager.LoadScene("SelectionScene");
        }
    }
}
