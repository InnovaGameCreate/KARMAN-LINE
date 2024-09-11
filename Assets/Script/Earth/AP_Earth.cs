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
    

    private void OnCollisionEnter(Collision collision)
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
    }
}
