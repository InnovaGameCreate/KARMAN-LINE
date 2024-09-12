using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp : MonoBehaviour
{
    private ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time == 1)
        {
            particleSystem.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided with: " + other.gameObject.name + " with tag: " + other.gameObject.tag);

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            particleSystem.Stop();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            particleSystem.Stop();
        }
    }

}