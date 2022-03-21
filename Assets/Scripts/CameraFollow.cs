using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public int deathDistance = 8;
    public Transform playerTransform;
    private float offset;
    public float winOffset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - playerTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z==0)
        {
            float newYPosition = playerTransform.position.y - offset;
            if (newYPosition > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x,
                                                 newYPosition,
                                                 transform.position.z);
            }
        }
        else
        {
            float newYPosition = playerTransform.position.y;
            float newXPosition = playerTransform.position.x;
            float newZPosition = playerTransform.position.z - winOffset;
            transform.position = new Vector3(newXPosition,
                                             newYPosition,
                                             newZPosition);
        }
    }
}
