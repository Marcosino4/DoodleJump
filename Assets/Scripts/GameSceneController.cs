using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public PlayerSkinManager playerSkinManager;

    void Start()
    {
        string selectedSkinName = PlayerPrefs.GetString("SelectedSkin");
        Sprite selectedSkin = Array.Find(playerSkinManager.skins, skin => skin.name == selectedSkinName);
        if (selectedSkin != null)
        {
            playerSkinManager.ChangeToSkin(selectedSkin);
        }
        else
        {
            Debug.LogError("No se pudo encontrar la skin seleccionada.");
        }
    }
}