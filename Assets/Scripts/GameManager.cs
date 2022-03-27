using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Vector3 rotation;
    public Vector3 spawnPosition;
    public GameObject platformPrefab;
    public GameObject jumperPrefab;
    public GameObject rottenPrefab;
    public GameObject boomballPrefab;
    public GameObject crystalPrefab;
    public Transform playerTransform;
    public int renderDistance = 15;
    public float spawnXStart = -3.5f;
    public float spawnXEnd = 3.5f;
    public float spawnYStart = 2f;
    public float spawnYEnd = 4f;
    public float crystalChance = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            CreatePlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (playerTransform.position.y > spawnPosition.y - renderDistance)
        {
            CreatePlatform();
            float randomNum = Random.value;
            if (randomNum < crystalChance)
            {
                CreateCrystal();
            }
        }
        
       
        
    }
    void CreateCrystal()
    {
        float randx = Random.Range(spawnXStart, spawnXEnd);
        spawnPosition.x = randx;
        Instantiate(crystalPrefab, spawnPosition, Quaternion.identity);
    }

    void CreatePlatform()
    {
        float randx = Random.Range(spawnXStart, spawnXEnd);
        float randy = Random.Range(spawnYStart, spawnYEnd);
        spawnPosition.y += randy;
        spawnPosition.x = randx;

        int rand_chance = Random.Range(1, 10);

        if (rand_chance == 1)
        {
            Instantiate(jumperPrefab, spawnPosition, Quaternion.identity);
        } else if (playerTransform.position.y * 100 > 3000 & rand_chance > 4)
        {
            Instantiate(rottenPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
        if (playerTransform.position.y * 100 > 8000)
        {
            if (rand_chance > 6 & rand_chance < 9)
            {
                Instantiate(boomballPrefab, spawnPosition, Quaternion.LookRotation(rotation));
            }
        }

    }
}

