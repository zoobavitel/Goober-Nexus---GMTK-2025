using UnityEngine;

public class PlayerControllerLukeVers : MonoBehaviour
{
    //For Organizing Editor Editable Stats
    [Header("PlayerStats")]
    public int moveSpeed;
    public int jumpForce;
    public GameObject groundCheckPos;
    public LayerMask groundLayer;

    //Private Stats
    private Rigidbody2D rb;
    private float horizontalInput;
    private bool isFacingRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting Rigidbody
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Call Inputs
        GetInput();
    }

    private void FixedUpdate()
    {
        //Move Character
        HorizontalMovement(horizontalInput);
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput > 0 && !isFacingRight || horizontalInput < 0 && isFacingRight)
        {
            Flip();
        }
        
        //Get Jump Input
        if (Input.GetButtonDown("Jump"))
        //if (Input.GetButton("Jump"))
        {
            if (GroundCheck() == true)
            {
                Debug.Log("Jumped!");
                //Jump
                Jump();
            }
            
        }

    }

    private void HorizontalMovement(float inputVal)
    {
        //Adds a Constant Force to the Rigidbody
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }

    private void Jump()
    {
        //Adds an Impulse Force to the Rigidbody 
        Vector2 jumpVelocity = new Vector2(0, jumpForce);
        rb.AddForce(jumpVelocity, ForceMode2D.Impulse);
    }

    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundCheckPos.transform.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        Vector2 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        isFacingRight = !isFacingRight;
    }
}
