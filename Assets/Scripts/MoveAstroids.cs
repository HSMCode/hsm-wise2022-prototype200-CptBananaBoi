using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAstroids : MonoBehaviour
{

    //Variables
    private bool left;
    public float speed;

    private Rigidbody _astroidRb;
    private GameObject _ship;

    


    // Start is called before the first frame update
    void Start()
    {
        

        _astroidRb = GetComponent<Rigidbody>();
        _ship = GameObject.FindWithTag("Ship");
    }
    
    void Awake() 
    {
        //is the Astroid coming from the left (or the right side)
        if(transform.position.x <= 0)
        {
            left = true;
        }else 
        {
            left = false;
            speed -= speed*2; //reverse flight directiion 
        }

        Destroy(this.gameObject, 10); //Destroys Astroid after 10 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //direction of flight, slight angle towards ship
        if(left)
        {
            _astroidRb.AddForce(((_ship.transform.position - transform.position).normalized) * speed*20);
        }
        else
        {
            _astroidRb.AddForce(((_ship.transform.position - transform.position).normalized)*-1 * speed*20);
        }

        //moves the astroid into the direction
        _astroidRb.AddForce(speed, 0, 0, ForceMode.Impulse);
        
    }

    //destroys astroid if its touching the ship
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ship"))
        {
            Destroy(this.gameObject);
            Debug.Log("Astroid destroyed");
        }
    }
}
