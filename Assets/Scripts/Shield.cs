using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shield : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Controller.playerInstance.shield.SetActive(true);
            PlayerShield.instance.anim.SetBool("Shield", true);
            Controller.playerInstance.godMode = true;
            Invoke("DeactivateShield", 7.15f);
            gameObject.SetActive(false);

        }
    }

    void DeactivateShield()
    {
        Controller.playerInstance.shield.SetActive(false);
        Controller.playerInstance.godMode = false;
        PlayerShield.instance.anim.SetBool("Shield", false);
    }
}
