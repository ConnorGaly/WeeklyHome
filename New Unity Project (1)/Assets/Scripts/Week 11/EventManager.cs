using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    // Start is called before the first frame update
    public delegate void GameObjectEvent(GameObject gameObject);
    public static GameObjectEvent OnSpawnEvent;
    public static GameObjectEvent OnDeathEvent;

    public delegate void FloatEvent(float amount, Transform objectHit);
    public static FloatEvent OnTakeDamage;
}
