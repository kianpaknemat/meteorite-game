using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    int hp = 5;
    float move;
    Animator anime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
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
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
