﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;
    public PlayerProgress playerProgress;

    private void Start()
    {
        playerProgress = FindObjectOfType<PlayerProgress>();
    }
    public void DealDamage(float Damage)
    {
        playerProgress.AddExp(Damage);
        value -= Damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
