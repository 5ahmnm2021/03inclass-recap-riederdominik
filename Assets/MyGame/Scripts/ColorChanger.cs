﻿using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Image imageColor;

    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(255,205,25,100),
            new Color32(95,34,0,100),
            new Color32(207,63,21,100),
            new Color32(102,47,84,100)
        };

        if (Input.GetKeyDown("space"))
        {
            imageColor.color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        ChangeColor();
    }
}
