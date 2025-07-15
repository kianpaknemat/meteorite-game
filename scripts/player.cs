using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    float move;
    Animator anime;
    public TextMeshProUGUI health;
    public int hp;
    AudioSource source;

    public float startDashTime = 0.5f;
    private float dashTimeRemaining;
    public float extraSpeed = 10f;
    private bool isDashing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        anime = GetComponent<Animator>();
        health.text = hp.ToString();
    }

    void Update()
    {
        anime.SetBool("running", move != 0);

        if (move > 0f)
            transform.eulerAngles = new Vector3(0, 0, 0);
        else if (move < 0f)
            transform.eulerAngles = new Vector3(0, 180, 0);

        if (Keyboard.current.spaceKey.isPressed && !isDashing)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTimeRemaining = startDashTime;
        }


        if (isDashing)
        {
            dashTimeRemaining -= Time.deltaTime;
            if (dashTimeRemaining <= 0)
            {
                speed -= extraSpeed;
                isDashing = false;
            }
        }
    }

    void FixedUpdate()
    {
        move = 0f;

        if (Keyboard.current.aKey.isPressed)
            move = -1f;
        else if (Keyboard.current.dKey.isPressed)
            move = 1f;

 
        float newX = rb.position.x + move * speed * Time.fixedDeltaTime;

        if (newX >= -10f && newX <= 10f)
        {
            rb.position = new Vector2(newX, rb.position.y);
        }
    }


    public void takeDameg(int dameg)
    {
        source.Play();
        hp -= dameg;
        health.text = hp.ToString();

        if (hp <= 0)
        {
            Destroy(gameObject);
            Invoke("ReturnToMainMenu", 2f); // صبر کن 2 ثانیه
        }
    }

    void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
