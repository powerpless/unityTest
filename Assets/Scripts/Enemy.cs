using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health = 100;
    [SerializeField] private int maxHealth = 100;
    
    public event Action OnDied;
    void Start()
    {
        health = maxHealth;
        Debug.Log($"Враг создан со здоровьем {health}");
    }

    public void Heal(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
        Debug.Log($"Враг похилился на {amount}HP, осталось {health} HP");
    }
    public void TakeDamage(int damage)
    {
        health = Mathf.Max(0, health - damage);
        Debug.Log($"Враг получил {damage} урона, осталось {health} HP");

        if (health == 0)
        {
            OnDied?.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(5);
        }
    }
}
