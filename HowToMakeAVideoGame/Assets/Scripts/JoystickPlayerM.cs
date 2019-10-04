using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerM : MonoBehaviour
{
    protected Joystick joystick;
    // Start is called before the first frame update
  
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
     
       
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 50f, rigidbody.velocity.y, joystick.Vertical * 100f);








    }
   
}
