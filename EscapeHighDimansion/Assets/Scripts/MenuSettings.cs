using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSettings : MonoBehaviour
{
    public void howtoP()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }
    public void gameOver()
    {
        SceneManager.LoadScene("Start Screen");
    }
    public void startGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void skipStory()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void skipStory2()
    {
        SceneManager.LoadScene("Level 4");
    }
}
