using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackPower : MonoBehaviour
{
    public float damageAmount = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider collision)
    {
        HP health = collision.gameObject.GetComponent<HP>();

        if (health != null)
        {
            // �_���[�W��^����
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Earth"))//collision�ɓ����Ă���Tag��Earth�̎�
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))//collision�ɓ����Ă���Tag��Enemy�̎�
         {
            Destroy(this.gameObject);
         }

        if (collision.gameObject.CompareTag("Bullet_E"))//collision�ɓ����Ă���Tag��Earth�̎�
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Laser"))//collision�ɓ����Ă���Tag��Earth�̎�
        {
            Destroy(this.gameObject);
        }
    }
}
