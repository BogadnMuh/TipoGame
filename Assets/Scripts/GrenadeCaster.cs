using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    public Transform grenadewTransform;

    public float force = 10;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenade = Instantiate(grenadePrefab);
            grenade.transform.position = grenadewTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadewTransform.forward * force);
        }
    }
}
