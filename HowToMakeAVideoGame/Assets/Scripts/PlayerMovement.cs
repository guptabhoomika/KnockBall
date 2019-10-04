using UnityEngine;

public class PlayerMovement : MonoBehaviour{

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
    [HideInInspector]
	public float forwardForce ;	// Variable that determines the forward force
    [HideInInspector]
	public float sidewaysForce;  // Variable that determines the sideways force
    public GameObject ground;
    private void Start()
    {
        rb.AddForce(0, 0, 2000f * Time.deltaTime);
    }
    private void Update()
    {
        rb.AddForce(0, 0,  1000f* Time.deltaTime);
    }

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate ()
	{
        
        if (rb.position.z<=500)
        {
          
            sidewaysForce = 200f;
            Movement(sidewaysForce);
           
        }
		if(rb.position.z >500 && rb.position.z<=1000)
        {
           
            sidewaysForce = 300f;
            Movement(sidewaysForce);
        }
        else
        {
           
            sidewaysForce = 400f;
            Movement(sidewaysForce);
        }
	}
    void Movement(float sidewaysForce)
    {
        

        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f || rb.position.x > 5 || rb.position.x <=-5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
