using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    public GameObject deathMenu;
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
}
