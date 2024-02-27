using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Controller.playerInstance.propeller.SetActive(true);
            PlayerPropeller.instance.anim.SetBool("Propeller", true);
            Controller.playerInstance.godMode = true;
            Controller.playerInstance.propellerActive = true;
            Invoke("DeactivatePropeller", 3);
            gameObject.SetActive(false);

        }
    }

    void DeactivatePropeller()
    {
        Controller.playerInstance.propeller.SetActive(false);
        Controller.playerInstance.godMode = false;
        Controller.playerInstance.propellerActive = false;
        PlayerPropeller.instance.anim.SetBool("Propeller", false);
    }
}
