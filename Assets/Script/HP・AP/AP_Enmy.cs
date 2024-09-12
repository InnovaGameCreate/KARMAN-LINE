using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AP_Enmy : MonoBehaviour
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
            // ダメージを与える
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Earth"))//collisionに入っているTagがEarthの時
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))//collisionに入っているTagがEnemyの時
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet_P"))//collisionに入っているTagがEarthの時
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Laser"))//collisionに入っているTagがEarthの時
        {
            Destroy(this.gameObject);
        }
    }
}
