using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public int playerDamage = 2;
    public Health health;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if (temperatureCurrent <= 0)
        {
            health.TakeDamage(playerDamage);
            freezeDamageTimer += freezeDamageDelay;
        }
        else
        {
            freezeDamageTimer -= Time.deltaTime;
        }
    }
}
