using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<Personaje> personajes;


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
        else
        {
            Destroy(gameObject);
        }
    }

    public Personaje GetRadomCharacter()
    {
        if (personajes.Count == 0)
        {
            Debug.LogError("No hay personajes en la lista.");
            return null;
        }

        int randomIndex = Random.Range(0, personajes.Count);
            
        return personajes[randomIndex];
    }


    public void PauseGame()
    {
        Time.timeScale = 0f;

    }
    public void ResumeGame()
    {
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

    public void LootBox()
    {
        SceneManager.LoadScene(2);
    }

}
