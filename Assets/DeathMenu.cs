using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public Text txtScore;
    public Text txtHighScore;
    public GameObject player;
    // Start is called before the first frame update
    void Update()
    {
        if(gameObject.activeSelf)
        {
            if (player)
            {
                txtScore.text = player.GetComponent<Controller>().getScore();
                if (PlayerPrefs.GetInt("highScore", 0) < int.Parse(player.GetComponent<Controller>().getScore()))
                {
                    PlayerPrefs.SetInt("highScore", int.Parse(player.GetComponent<Controller>().getScore()));
                }
                txtHighScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();
            }

            
            
        }
    }

}
