using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AP_Laser : MonoBehaviour
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
        HP_Earth health = collision.gameObject.GetComponent<HP_Earth>();

        if (health != null)
        {
            // ダメージを与える
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Earth"))//collisionに入っているTagがEarthの時
        {
            Destroy(this.gameObject);
        }
    }
}
