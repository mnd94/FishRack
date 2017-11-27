using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour {


    [SerializeField]
    private float damage = -5;

    void OnTriggerEnter(Collider other)
    {
       other.gameObject.GetComponent<TestEnemy>().TakeDamage(damage);
    }
}
