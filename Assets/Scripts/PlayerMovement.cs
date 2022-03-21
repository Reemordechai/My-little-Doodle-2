using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower = 15;
    public int score;
    public Transform playerTransform;
    public int crystalCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower;
        Vector3 newMovement = rb.velocity;
        newMovement.x = horizontalMovement;
        rb.velocity = newMovement;

        int currentScore = Mathf.RoundToInt(transform.position.y * 100);
        if (currentScore > score)
            score = currentScore;


        if (transform.position.x >= 3.8f || transform.position.x <= -3.8f)
        {
            float newPosition = transform.position.x;
            newPosition *= -1;
            newPosition += (transform.position.x / 20);
            transform.position = new Vector3(newPosition,
                                             transform.position.y,
                                             transform.position.z);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BoomBoom>())
        {
            float newZPosition = playerTransform.position.z - 3;
            transform.position = new Vector3(transform.position.x,
                                            transform.position.y,
                                            newZPosition);
        }
    }
}
