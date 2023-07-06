using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class TitleChgScene : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;
    private Button NewGameButton;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        NewGameButton = GetComponent<Button>();
        NewGameButton.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        audioSource.PlayOneShot(sound1);
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
}