using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int MaxHealth; // Health Limit
    public int Health;
    public int Damage;
    public int MoveSpeed;
    public int AttackSpeed;

    private void Start()
    {
        
    }
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        Debug.Log("Health: " + Health);
    }
}
