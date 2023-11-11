using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    public float MaxxHealth,CurrentHealth;

    Damageable playerDamageable;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerDamageable = player.GetComponent<Damageable>();
        MaxxHealth = playerDamageable.MaxHealth;
        CurrentHealth = playerDamageable.Health;

    }
    private void Start()
    {
        totalHealthBar.fillAmount = MaxxHealth / 10;
    }

    private void Update()
    {
        CurrentHealth = playerDamageable.Health;
        currentHealthBar.fillAmount = CurrentHealth / 10;

    }

}
