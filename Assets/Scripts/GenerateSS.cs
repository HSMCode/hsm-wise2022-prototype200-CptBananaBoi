using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSS : MonoBehaviour
{
    public Transform SpaceStation;
    public int fieldRadius = 100;
    public int SpaceStations = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int loop = 0; loop < SpaceStations; loop++)
        {
            Transform temp = Instantiate(SpaceStation, Random.insideUnitSphere * fieldRadius, Random.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
