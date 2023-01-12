using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAstroids : MonoBehaviour
{

    // Varibales
    private float repeatRateOnStart = 0.5f;
    public GameObject Astroid;

    public float astroidDistance = 40f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawningAstroid", 3f, repeatRateOnStart);
        InvokeRepeating("SpawningAstroid", 3f, repeatRateOnStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawningAstroid()
    {
        //more dynamic spawn rate
        float repeatRateModifier = Random.Range(0, 15);

        if (repeatRateModifier <= 5)
        {
            // Instantiate a clone from the prefab Astroid at generated position
            Instantiate(Astroid, GenerateSpawnPosition(), Astroid.transform.rotation);
        }
        else
        {
            //Debug.Log("No Astroid");
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        //bool left; //comes from the left
        float ySpawnRange = astroidDistance; //spawn Range on the y-Axis
        float xSpawn = astroidDistance; //spawn Position x-Axis. Does Change when the astroid comes from the left

        //Randomly decides if the astroid is coming from the left
        if(Random.Range(0,10) >= 5)
        {
            //left = true;
            xSpawn -= xSpawn*2;
        }
        // Create a random enemy spawn position 
        Vector3 astroidSpawnPos = new Vector3(xSpawn, 1,
            Random.Range(-ySpawnRange, ySpawnRange));

        return astroidSpawnPos;
    }
}
