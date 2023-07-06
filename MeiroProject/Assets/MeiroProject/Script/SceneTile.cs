using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTile : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //public void SwitchScene()
    //{
    //    SceneManager.LoadScene("2nd");
    //}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //SwitchScene();
            audioSource.PlayOneShot(sound1);
            Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
            ;

        }
        
    }
}
