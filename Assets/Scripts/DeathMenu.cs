using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathMenu;
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
        deathMenu.gameObject.SetActive(true);
    }
}
