using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameObject p1Object;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded;

    void Start()
    {
        p1Object = GameObject.FindWithTag("Player1");
        rb = p1Object.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //player1 controls
        movement.x = 0;
        movement.y = 0;

        if (Input.GetKey(KeyCode.A)) // Move Left
            movement.x = -1;
        if (Input.GetKey(KeyCode.D)) // Move Right
            movement.x = 1;

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * GameManager.p1.maxJump, ForceMode2D.Impulse);
            isGrounded = false; // Prevent further jumping until grounded
        }

    }

     void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement.x * GameManager.p1.maxSpeed, rb.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision occurring");
        Debug.Log(collision.gameObject.tag);
        // Check if the player is grounded
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}

