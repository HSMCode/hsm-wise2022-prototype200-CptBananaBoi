using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    //variables
    //change this to let the destruction of the ship take longer or shorter
    public float interval = 10f;

    // Start is called before the first frame update
    void Start()
    {
     Destroy(gameObject,interval);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
