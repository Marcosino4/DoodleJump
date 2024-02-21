using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlatform : MonoBehaviour
{
    GameObject GameObject;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            this.StartCoroutine(this.Break());
        }
    }
    private IEnumerator Break()
    {
        _animator.SetBool("BreakPlatform", true);
        yield return new WaitForSecondsRealtime(0.5f);
        gameObject.SetActive(false);
    }
}
