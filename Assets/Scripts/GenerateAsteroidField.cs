using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int FieldRadius = 100;
    public int asteroidCount = 500;

    // Start is called before the first frame update
    void Start()
    {
        for (int loop = 0; loop < asteroidCount; loop++)
        {
            Transform temp = Instantiate(asteroidPrefab, Random.insideUnitSphere * FieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(5f, 150f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
