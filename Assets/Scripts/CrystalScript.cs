using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public AudioClip oudio;
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
            Camera maincam = GameObject.Find("Main Camera").GetComponent<Camera>();
            AudioSource.PlayClipAtPoint(oudio, maincam.transform.position, 0.4f);
            Destroy(gameObject);
            playerMovement.crystalCounter += 1;
        }
    }
}
