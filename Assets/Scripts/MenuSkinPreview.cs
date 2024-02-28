using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSkinPreview : MonoBehaviour
{
    public Sprite[] skins;
    public Image skinPreviewImage; 
    private int currentSkinIndex = 0;
    public Sprite selectedSkin;


    void Start()
    {
        UpdatePreview();
    }

    public void ChangeToNextSkin()
    {
        currentSkinIndex = (currentSkinIndex + 1) % skins.Length;
        selectedSkin = skins[currentSkinIndex];
        UpdatePreview();
    }

    public void ChangeToPreviousSkin()
    {
        currentSkinIndex = (currentSkinIndex - 1 + skins.Length) % skins.Length;
        selectedSkin = skins[currentSkinIndex];
        UpdatePreview();

    }
    public Sprite GetSelectedSkin()
    {
        return selectedSkin;
    }

    void UpdatePreview()
    {
        if (skins.Length > 0)
        {
            skinPreviewImage.sprite = skins[currentSkinIndex];
        }
        else
        {
            Debug.LogError("No hay skins asignadas al arreglo.");
        }
    }
}
