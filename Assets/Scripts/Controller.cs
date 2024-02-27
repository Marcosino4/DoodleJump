using System;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text scoreText;
    public static Controller playerInstance;
    public GameObject deathMenu;
    public bool godMode;

    private int actualposY;
    private Rigidbody2D _rb;
    private float moveInput;
    private float speed = 10f;
    private float topScore;

    private void Awake()
    {
        if (!playerInstance)
        {
            playerInstance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 5f;
        _rb.velocity = Vector3.zero;
        godMode = false;
    }

    private void FixedUpdate()
    {
        // Gira el sprite del jugador dependiendo de la dirección en la que se mueve
        if (moveInput < 0)
            GetComponent<SpriteRenderer>().flipX = false;
        else
            GetComponent<SpriteRenderer>().flipX = true;

        // Actualiza el topScore si la posición en Y del jugador es mayor que el topScore
        if (_rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = Mathf.Round(topScore).ToString();

        // Velocidad del jugador y movimiento
        moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveInput * speed, _rb.velocity.y);

        if (transform.position.y < actualposY - 20)
        {
            Instantiate(deathMenu);
        }
        else
        {
            actualposY = (int)transform.position.y;
        }
    }

    public String getScore()
    {
        return Mathf.Round(topScore).ToString();
    }

  
}

