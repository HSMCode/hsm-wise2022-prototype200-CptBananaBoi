using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    //Variables 

    //moving Ship
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] float turnSpeed;    
    [SerializeField] float speed;

    //Attributes
    private int lives = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //moving Ship
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);

        //destroy if lives are down to zero and end the game
        if(lives == 0)
        {
            //space for effects
            Destroy(this.gameObject, 2);
            Debug.Log("No Lives left");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //feedback message if the ship has reached the goal
        if(other.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Reached Goal");
        }

        // feedback mesage if a astroid hits the ship
        if(other.gameObject.CompareTag("Astroid"))
        {
            Debug.Log("Hit by Astroid!");
            lives--; //reduces lives by one
        }
    }

}
