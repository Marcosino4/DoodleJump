using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkinManager : MonoBehaviour
{
    public Sprite[] skins;
    private int currentSkinIndex = 0;

    private SpriteRenderer playerSpriteRenderer;

    void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        if (skins.Length > 0)
        {
            playerSpriteRenderer.sprite = skins[currentSkinIndex];
        }
    }

    public void ChangeToNextSkin()
    {
        currentSkinIndex = (currentSkinIndex + 1) % skins.Length;
        playerSpriteRenderer.sprite = skins[currentSkinIndex]; 
    }

    public void ChangeToSkin(Sprite selectedSkin)
    {
        int skinIndex = -1;

        for (int i = 0; i < skins.Length; i++)
        {
            if (skins[i] == selectedSkin)
            {
                skinIndex = i;
                break;
            }
        }

        if (skinIndex != -1)
        {
            currentSkinIndex = skinIndex;
            playerSpriteRenderer.sprite = skins[currentSkinIndex];
        }
        else
        {
            Debug.LogWarning("Skin seleccionada no encontrada en el arreglo.");
        }
    }
}
