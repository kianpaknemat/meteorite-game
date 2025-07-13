using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    float hp = 5f;
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

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        print(move * speed);
    }
}
