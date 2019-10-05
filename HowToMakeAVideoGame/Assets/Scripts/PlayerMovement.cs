using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour{

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
    [HideInInspector]
	public float forwardForce=1000f ;	// Variable that determines the forward force
    [HideInInspector]
	public float sidewaysForce;  // Variable that determines the sideways force


    

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        transform.Translate(Vector3.right * CrossPlatformInputManager.GetAxis("Horizontal") * 10 * Time.deltaTime);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
