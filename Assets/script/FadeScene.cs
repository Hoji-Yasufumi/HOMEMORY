using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScene : MonoBehaviour
{
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
        }
    }
}
