using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public static PlayerShield instance;
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
