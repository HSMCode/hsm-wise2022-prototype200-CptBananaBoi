using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
   //variables
   public float currentTime = 0f;
   public float startingTime = 10f;

   //Connection to Canvas Text
   public Text CountDownText;

   void Start()
   {
    currentTime = startingTime;
   }


   void Update()
   {
    //counts down 1s instead of 1 frame
    currentTime -= 1 * Time.deltaTime;

    //displays whole number
    CountDownText.text = currentTime.ToString("0");

    // changing color
    CountDownText.color = Color.red;

    //makes countdown stop at 0
    if(currentTime <= 0)
    {
       SceneManager.LoadScene("GameOver"); 
    }
   }
}
