using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public GameManager gameManager; // Aseg�rate de asignar esto desde el Editor de Unity
    public Image characterImage; // El objeto Image donde se mostrar� la imagen del personaje

    void Start()
    {
        Personaje randomCharacter = gameManager.GetRadomCharacter();

        if (randomCharacter != null)
        {
            characterImage.sprite = randomCharacter.imagen;
        }
        else
        {
            Debug.LogError("No se pudo obtener un personaje aleatorio del GameManager.");
        }
    }
}