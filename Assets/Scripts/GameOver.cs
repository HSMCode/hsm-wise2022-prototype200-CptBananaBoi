using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("CptBananaBoi");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
