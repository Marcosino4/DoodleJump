using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public GameObject deathMenu;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        deathMenu.SetActive(false);
    }
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    public void DeathMenu()
    {
        deathMenu.SetActive(true);
    }
    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public GameObject getPause()
    {
        return pauseMenu;
    }

}
