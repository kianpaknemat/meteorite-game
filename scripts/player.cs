using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    float move;
    Animator anime;
    public TextMeshProUGUI health;
    public int hp;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        health.text = hp.ToString();
    }

    void Update()
    {
        anime.SetBool("running", move != 0);

        if (move > 0f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (move < 0f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void FixedUpdate()
    {
        move = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            move = -1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            move = 1f;
        }

        rb.position += new Vector2(move * speed * Time.fixedDeltaTime, rb.linearVelocity.y);

    }

    public void takeDameg(int dameg)
    {
        hp -= dameg;
        health.text = hp.ToString();
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
