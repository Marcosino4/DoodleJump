using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpad : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (!Controller.playerInstance.isDead && collider.CompareTag("Player"))
        {
            // Si el jugador colisiona con el trigger, se le añade una fuerza hacia arriba y se activa la animación de salto
            anim.SetBool("Jump", true);
            collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1200f);
        }
    }
}
