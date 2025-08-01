using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2D : MonoBehaviour
{
    // Public variables
    public float speed = 5f; // The speed at which the player moves

    bool isFacingRight = true;

    // Private variables 
    private Rigidbody2D rb; // Reference to the Rigidbody2D component attached to the player
    private float horizontalInput; // Stores the horizontal input

    void Start()
    {
        // Initialize the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        // Prevent the player from rotating
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        // Get horizontal input using the new Input System
        horizontalInput = 0f;
        if (Keyboard.current != null)
        {
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                horizontalInput = 1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                horizontalInput = -1f;
        }
        FlipSprite();
    }

    void FixedUpdate()
    {
        // Apply horizontal movement to the player in FixedUpdate for physics consistency
        Vector2 velocity = rb.linearVelocity;
        velocity.x = horizontalInput * speed;
        rb.linearVelocity = velocity;
    }

    void FlipSprite()
    {
        // Only flip if there's actual movement input
        if (horizontalInput != 0)
        {
            // If moving right and facing left, flip to face right
            if (horizontalInput > 0 && !isFacingRight)
            {
                Flip();
            }
            // If moving left and facing right, flip to face left
            else if (horizontalInput < 0 && isFacingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        // Flip the sprite by inverting the X scale
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;


        // Toggle the facing direction
        isFacingRight = !isFacingRight;
    }
}
