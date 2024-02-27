using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text scoreText;
    public static Controller playerInstance;
    public bool godMode;
    public GameObject shield;
    public GameObject propeller;
    public GameObject jetpack;
    public bool propellerActive;
    public bool jetpackActive;

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
            transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, 0);

        else
            transform.rotation = new Quaternion(transform.rotation.x, -180, transform.rotation.z, 0);

        // Actualiza el topScore si la posición en Y del jugador es mayor que el topScore
        if (_rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = Mathf.Round(topScore).ToString();

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN

        // Velocidad del jugador y movimiento
        moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveInput * speed, _rb.velocity.y);

#elif UNITY_ANDROID

        // Gira el sprite del jugador dependiendo de la dirección en la que se mueve
        moveInput = Input.acceleration.x;
        if (moveInput < 0)
            transform.position -= transform.right * speed * Time.deltaTime;
        if (moveInput > 0)
            transform.position += transform.right * speed * Time.deltaTime;

#endif



        if (transform.position.y < actualposY - 20)
        {
            CanvasManager.instance.DeathMenu();
        }
        else
        {
            actualposY = (int)transform.position.y;
        }

        if(propellerActive)
        {
            float propellerSpeed = 15f;
            _rb.velocity = new Vector2(moveInput * speed, propellerSpeed);
        }else if (jetpackActive)
        {
            float jetpackSpeed = 25f;
            _rb.velocity = new Vector2(moveInput * speed, jetpackSpeed);
        }
    }

    public String getScore()
    {
        return Mathf.Round(topScore).ToString();
    }

}

