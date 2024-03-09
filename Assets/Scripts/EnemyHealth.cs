using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;

    public void DealDamage(float Damage)
    {
        value -= Damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
