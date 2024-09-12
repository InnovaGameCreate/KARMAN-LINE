using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AP_Particle : MonoBehaviour
{
    public float damageAmount = 10f;

    private ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided with: " + other.gameObject.name + " with tag: " + other.gameObject.tag);

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            HP health = other.gameObject.GetComponent<HP>();
            if (health != null)
            {
                Debug.Log("Applying damage: " + damageAmount);
                health.TakeDamage(damageAmount);
            }
            else
            {
                Debug.LogError("No HP component found on: " + other.gameObject.name);
            }
        }
    }
}
