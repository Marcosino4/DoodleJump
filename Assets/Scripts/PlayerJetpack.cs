using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetpack : MonoBehaviour
{
    public static PlayerJetpack instance;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
}
