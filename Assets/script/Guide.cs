using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    public GameObject guideButton;
    public GameObject guideCWindow;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        if (guideCWindow != null)
        {
            guideCWindow.SetActive(false);
        }

        // Get the SpriteRenderer component from this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Right-click to enable the sprite
        if (Input.GetMouseButtonDown(1))
        {
            if (spriteRenderer != null)
                spriteRenderer.enabled = true;
        }

        // Left-click to disable the sprite
        if (Input.GetMouseButtonDown(0))
        {
            if (spriteRenderer != null)
                spriteRenderer.enabled = false;
        }
    }
}
