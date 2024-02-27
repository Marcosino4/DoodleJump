using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;

    }
    public void ResumeGame()
    {
        CanvasManager.instance.getPause().SetActive(false);
        Time.timeScale = 1f;

    }
    public void BackToMenu() //Volver al menu principal
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()   //Reiniciar partida
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }

                

}
