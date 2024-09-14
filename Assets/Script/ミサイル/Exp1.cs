using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp1 : MonoBehaviour
{
    private ParticleSystem particleSystem;
    [SerializeField] private float lifetime;
    private bool isStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStopped) return; // すでに停止しているなら、更新処理をスキップ

        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            StopParticleSystem();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (isStopped) return; // すでに停止しているなら、処理をスキップ

        if (other.CompareTag("Bullet_E"))
        {
            Destroy(other);
            StopParticleSystem();
        }
        else if (other.CompareTag("Enemy"))
        {
            StopParticleSystem();
        }
    }

    private void StopParticleSystem()
    {
        if (!isStopped)
        {
            particleSystem.Stop();
            isStopped = true;
        }
    }
}
