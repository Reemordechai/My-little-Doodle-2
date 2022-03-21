using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            playerMovement= other.GetComponent<PlayerMovement>();
            Destroy(gameObject);
            playerMovement.crystalCounter += 1;
        }
    }
}
