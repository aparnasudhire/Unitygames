using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the movement speed.
    public float jumpForce = 5f; // Adjust this value to control the jump force.
    [SerializeField] public bool clickedonplay = false;
    private Rigidbody2D rb;

    private float initialMoveSpeed = 5.0f; // The initial move speed.
    private float speedIncreaseRate = 0.1f; // The rate at which the speed increases per second.

    public Button Play;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Make sure the player object has a Rigidbody2D component attached.
    }

    private void Update()
    {
        if(clickedonplay){
            MovePlayerRight();
            HandleJump();
        }
        
    }

    public void play(){
        clickedonplay = true;
        rb = GetComponent<Rigidbody2D>();
        Play.gameObject.SetActive(false);
        // Unfreeze the X and Y positions
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    /*private void MovePlayerRight()
    {
        Vector2 movement = new Vector2(moveSpeed, rb.velocity.y);
        rb.velocity = movement; // Set the velocity to move the player to the right.
    }*/

    private void MovePlayerRight()
    {
        // Calculate the new speed based on time.
        float currentTime = Time.timeSinceLevelLoad;
        float newMoveSpeed = initialMoveSpeed + speedIncreaseRate * currentTime;

        Vector2 movement = new Vector2(newMoveSpeed, rb.velocity.y);
        rb.velocity = movement; // Set the velocity to move the player to the right.
    }

    private void HandleJump()
    {
        // Check if the mouse button is clicked (left mouse button in this case).
        if (Input.GetMouseButtonDown(0))
        {
            // Apply an upward force to make the player jump.
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
