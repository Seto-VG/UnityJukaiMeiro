using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Title2ChgScene : MonoBehaviour
{
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;
    public void title2ChgScene()
    {
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
}
