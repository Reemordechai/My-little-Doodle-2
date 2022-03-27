using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_script : MonoBehaviour
{
    [Range(5,20)]
    public float jumpForce;
    public AudioClip oudio;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    // when the object is triggered by another it looks for the component
    // "playermovement" which is on the player. it then acceccss its velocity
    // and replaces its Y velocity with a number we dictate
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                Camera maincam = GameObject.Find("Main Camera").GetComponent<Camera>();
                AudioSource.PlayClipAtPoint(oudio, maincam.transform.position);
                
            }
            
        }

    }
}
