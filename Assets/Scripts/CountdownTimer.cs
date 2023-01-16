using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
   //variables
   public float currentTime = 0f;
   float startingTime = 10f;

   //Connection to Canvas Text
   public Text countdownText;

   void Start()
   {
    currentTime = startingTime;
   }


   void Update()
   {
    //counts down 1s instead of 1 frame
    currentTime -= 1 * Time.deltaTime;

    //displays whole number
    countdownText.text = currentTime.ToString("0");

    // changing color
    countdownText.color = Color.red;

    //makes countdown stop at 0
    if(currentTime <= 0)
    {
       currentTime = 0; 
    }
   }
}
