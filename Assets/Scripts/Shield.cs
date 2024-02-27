using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Animator anim;
    private bool shieldActive;

    void Update()
    {
        if (shieldActive)
        {
            transform.position = GameObject.Find("Player").transform.position;
            Controller.playerInstance.godMode = true;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("ShieldOff"))
        {
            shieldActive = false;
            Controller.playerInstance.godMode = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            anim.SetBool("Activate", true);
            shieldActive = true;
            Invoke("DeactivateShield", 7.15f);
        }
    }

    void DeactivateShield()
    {
        anim.SetBool("Activate", false);
        shieldActive = false;
        gameObject.SetActive(false);
    }
}
