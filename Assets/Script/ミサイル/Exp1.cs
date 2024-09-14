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
        if (isStopped) return; // ���łɒ�~���Ă���Ȃ�A�X�V�������X�L�b�v

        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            StopParticleSystem();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (isStopped) return; // ���łɒ�~���Ă���Ȃ�A�������X�L�b�v

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
