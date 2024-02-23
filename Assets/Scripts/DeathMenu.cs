using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.SetActive(false);
    }
    void FixedUpdate()
    {
        if(Controller.playerInstance.isDead)
        {
            this.gameObject.SetActive(true);
            this.transform.position = new Vector2(transform.position.x, Controller.playerInstance.transform.position.y - 1000f);
        }
    }
}
