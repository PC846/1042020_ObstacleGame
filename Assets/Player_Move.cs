using UnityEngine;

public class Player_Move : MonoBehaviour
{
    // Reference to Rigidbody
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Marked this as "Fixed"Update because we
    // are using it to mess with physics using Unity.

    // Time.deltaTime makes it so that it looks the same
    // accross all computers. It takes how much time gathered
    // from last frame.

   
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce* Time.deltaTime); // adds a forward force 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(sidewaysForce) * Time.deltaTime, 0, 0);
        }

    }
}
