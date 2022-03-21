using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    [Range(5, 100)]
    public float jumpForce;
    public Collider playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Vector3 newVelocity = rb.velocity;
            newVelocity.y = jumpForce;
            newVelocity.z = jumpForce;
            rb.velocity = newVelocity;
            playerCollider = other.GetComponent<Collider>();
            playerCollider.isTrigger = false;
            
        }

    }
}
