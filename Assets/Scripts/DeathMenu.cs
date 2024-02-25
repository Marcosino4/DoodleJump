using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject gameOver;
    private void OnEnable()
    {
        Controller.onPlayerDeath += DisplayGameOverMenu;
    }
    private void OnDisable()
    {
        Controller.onPlayerDeath -= DisplayGameOverMenu;
    }
    public void DisplayGameOverMenu()
    {
        gameOver.gameObject.SetActive(true);
    }
}
