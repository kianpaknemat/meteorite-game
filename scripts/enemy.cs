using UnityEngine;

public class enemy : MonoBehaviour
{

    public float minSpeed;
    public float maxSpeed;
    float speed;
    Rigidbody2D rb;
    player playerScript;
    public int damege;


    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        print(speed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    void Update()
    {
        transform.Translate(Vector2.down *speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D hitobject)
    {
        if(hitobject.tag == "Player")
        {
            playerScript.takeDameg(damege);
        }
    }
}
