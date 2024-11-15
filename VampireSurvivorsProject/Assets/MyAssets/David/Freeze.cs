using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    public float freezeDuration = 3f;

    private bool isFrozen = false;
    private List<Enemy> enemies;

    private void Start()
    {
        enemies = new List<Enemy>();
    }

    public void ActiveFreeze()
    {
        if (isFrozen)
        {
            StartCoroutine(FreezeEnemies());
        }
    }

    private IEnumerator FreezeEnemies()
    {
        isFrozen = true;

        enemies.AddRange(FindObjectsOfType<Enemy>());
        foreach (Enemy enemy in enemies)
        {
            if (enemy != null) 
            {
            enemy.Freeze();
            }
        }

        yield return new WaitForSeconds(freezeDuration);

        foreach(Enemy enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.Unfreeze();
            }
        }

        enemies.Clear();
        isFrozen = false;
    }

}

    
