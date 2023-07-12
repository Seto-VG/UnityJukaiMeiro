using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class Test : MonoBehaviour
{
    private Button NewGameButton;

    // Use this for initialization
    void Start()
    {
        NewGameButton = GetComponent<Button>();
        NewGameButton.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
}