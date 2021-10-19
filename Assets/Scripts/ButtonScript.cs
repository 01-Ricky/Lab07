using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
