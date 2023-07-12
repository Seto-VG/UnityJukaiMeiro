using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndingChgScene : MonoBehaviour
{
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;
    public void EndingChgSccne()
    {
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
}