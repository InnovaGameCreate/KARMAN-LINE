using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp : MonoBehaviour
{
    private ParticleSystem particleSystem;
    [SerializeField] private float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        lifetime = lifetime - Time.deltaTime;
        if (lifetime < 0)
        {
            particleSystem.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
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