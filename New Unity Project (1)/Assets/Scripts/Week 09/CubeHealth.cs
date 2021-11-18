using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    public float health = 100;

    public void TakeDamage()
    {
        health -= 50;
        if (health <= 0)
        {
            //Dew It
            Destroy(gameObject);
        }
    }
}
