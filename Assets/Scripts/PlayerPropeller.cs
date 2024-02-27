using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPropeller : MonoBehaviour
{
    public static PlayerPropeller instance;
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
