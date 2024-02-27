using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Controller.playerInstance.jetpack.SetActive(true);
            PlayerJetpack.instance.anim.SetBool("Jetpack", true);
            Controller.playerInstance.godMode = true;
            Controller.playerInstance.jetpackActive = true;
            Invoke("DeactivateJetpack", 4f);
            gameObject.SetActive(false);

        }
    }

    void DeactivateJetpack()
    {
        Controller.playerInstance.jetpack.SetActive(false);
        Controller.playerInstance.godMode = false;
        Controller.playerInstance.jetpackActive = false;
        PlayerJetpack.instance.anim.SetBool("Jetpack", false);
    }
}
