using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S, jump = KeyCode.W;
    public float speed = 10, jumpHeight = 15;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey() is for HOLDING a key
        // Input.GetKeyDown() is for PRESSING a key
        // Input.GetKeyUp() is for RELEASING a key
        if (Input.GetKey(left)) // Input.GetKey() is for HOLDING the left button
        {
            // Get The GameObject's Rigidbody2D component and set its velocity to be to the left at the given speed
            _rb.velocity = Vector2.left * speed;
        }
        if (Input.GetKey(right)) // Check for the player HOLDING the right button
        {
            // Get The GameObject's Rigidbody2D component and set its velocity to be to the right at the given speed
            _rb.velocity = Vector2.right * speed;
        }
        if (Input.GetKey(down))  // Check for the player HOLDING the down button
        {
            // Get The GameObject's Rigidbody2D component and set its velocity to be to the down at the given speed
            _rb.velocity = Vector2.down * speed;
        }
        if (Input.GetKey(up)) // Check for the player HOLDING the up button
        {
            // Get The GameObject's Rigidbody2D component and set its velocity to be to the up at the given speed
            _rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKeyDown(jump))  // Check for the player PRESSING the jump button
        {
            // Get The GameObject's Rigidbody2D component and set its velocity to be to the up at the given jump height
            _rb.velocity = Vector2.up * jumpHeight;
        }
    }
}