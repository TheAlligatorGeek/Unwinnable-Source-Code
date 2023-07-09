using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene("Level One");
    }
    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void LoadCredits() 
    {
        SceneManager.LoadScene("Credits");
    }
    public void LoadMenu() 
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().StopPlaying("Theme");
    }
}
