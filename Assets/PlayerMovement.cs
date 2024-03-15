using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //referencing Rigidbody as rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // FIXEDUPDATE CAUSE PHYSICS RAHHH
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce (0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
