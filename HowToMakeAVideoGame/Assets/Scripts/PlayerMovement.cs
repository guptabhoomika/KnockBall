using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    [HideInInspector]
    public float forwardForce = 1000f;	// Variable that determines the forward force
    [HideInInspector]
    public float sidewaysForce;  // Variable that determines the sideways force

    public float jumpforce; //force applied to jump player up
    public float distanceToGround = 0.973f;  // it store the distance between the player and ground 


    private bool isGrounded;         // bool condition to check if our player is grounded or not
    
   

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.


    void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, distanceToGround ); // raycast is used to determine the distance between ground and player

        transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        transform.Translate(Vector3.right * CrossPlatformInputManager.GetAxis("Horizontal") * 10 * Time.deltaTime);
        

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Update()
    {
        if (isGrounded == true)   // its checking if player is grounded or not
        {           
            if (Input.GetKeyDown(KeyCode.UpArrow) )
            {
                rb.velocity = Vector3.up * jumpforce;               
            }          
        }
    }    
}
