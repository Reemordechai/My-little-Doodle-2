using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exterminator : MonoBehaviour
{
    public GameObject loseCanvas;
    public Transform cameraTransform;
    public int cameraOffSet = 23;
    private float highestPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            loseCanvas.SetActive(true);
        }
        Destroy(other.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        float newYPosition = cameraTransform.position.y - cameraOffSet;
        if (newYPosition>highestPos)
        {
            transform.position = new Vector3(transform.position.x,
                                                    newYPosition,
                                                    transform.position.z);
            highestPos = newYPosition;
        }
       
    }
}
