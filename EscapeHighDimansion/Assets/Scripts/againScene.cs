using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class againScene : MonoBehaviour
{
    Damageable playerDamageable;
    int Health;

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerDamageable = player.GetComponent<Damageable>();
        Health = playerDamageable.Health;

    }

    void Update()
    {
        Vector2 currentpos = transform.position;
        Health = playerDamageable.Health;
        if (Health <= 0) 
        {
            Invoke("DeadEnd", 1f);
        }
        else if (currentpos.y <=-15)
        {
            Invoke("DeadEnd", 1f);
        }
    }
    private void DeadEnd()
    {
        SceneManager.LoadScene("End Screen");
    }
}
