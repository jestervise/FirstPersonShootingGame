using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {
    public GameObject crackedVersion;
    public float health = 50f;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die() {
        Instantiate(crackedVersion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
