using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int addhealth = 20;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCharacter"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.Heal(addhealth);
            Destroy(gameObject);
        }
    }
}