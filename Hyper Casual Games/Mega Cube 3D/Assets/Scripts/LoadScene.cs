using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{   
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);       
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Opening Scene");       
    }

    public void QuitGame()
    {
        Application.Quit();        
    }
}
