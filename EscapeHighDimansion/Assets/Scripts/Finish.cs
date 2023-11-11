using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.gameObject.name == "Player" && !levelCompleted)
        {
            CompleteLevel();
            levelCompleted = true;
            Invoke("CompleteLevel", 0.5f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
