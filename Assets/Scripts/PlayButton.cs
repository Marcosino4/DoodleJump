using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public MenuSkinPreview characterSelection;

    public void OnPlayButtonClicked()
    {
        Sprite selectedSkin = characterSelection.GetSelectedSkin();
        PlayerPrefs.SetString("SelectedSkin", selectedSkin.name);
        SceneManager.LoadScene(1); 
    }
}
