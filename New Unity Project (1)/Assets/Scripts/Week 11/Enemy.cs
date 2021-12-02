using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health = 100f;

    private void OnEnable()
    {
        EventManager.OnTakeDamage += TakeDamage;
    }

    private void OnDisable()
    {
        EventManager.OnTakeDamage -= TakeDamage;
    }

    private void Start()
    {
        EventManager.OnSpawnEvent?.Invoke(gameObject);
    }

    private void TakeDamage(float amount, Transform objectHit)
    {
        if(objectHit != transform)
        {
            return;
        }
        health += amount;
       if(health <= 0)
        {
            EventManager.OnDeathEvent?.Invoke(gameObject);
            Destroy(gameObject);
        }
    }


    
}
