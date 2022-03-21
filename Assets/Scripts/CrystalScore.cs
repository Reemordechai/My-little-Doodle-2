using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalScore : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = playerMovement.crystalCounter.ToString();
    }
}
