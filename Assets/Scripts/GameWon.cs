using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("CptBananaBoi");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
