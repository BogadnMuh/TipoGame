using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float damage = 50;

    public float delay = 3;
    public GameObject explotionPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explotion", delay);
    }

    private void Explotion()
    {
        Destroy(gameObject);
        var explotion = Instantiate(explotionPrefab);
        explotion.transform.position = transform.position;
        explotion.GetComponent<Explotion>().damage = damage;
    }
}
