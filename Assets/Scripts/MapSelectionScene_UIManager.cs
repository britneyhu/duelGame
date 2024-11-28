using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapSelectionScene_UIManager : MonoBehaviour
{
    public Button map1_Button;

    void Start()
    {
        map1_Button.onClick.AddListener(()=> onButtonClick(0));
    }

    void onButtonClick(int index){
        GameManager.selectMap(0);
        Debug.Log($"Button: Player clicked map {index+1}");
        SceneManager.LoadScene("FightScene");
    }
}
