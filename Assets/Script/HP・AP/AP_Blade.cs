using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AP_Blade : MonoBehaviour
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
        HP_Enemy health = collision.gameObject.GetComponent<HP_Enemy>();

        if (health != null)
        {
            // ƒ_ƒ[ƒW‚ğ—^‚¦‚é
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Enemy"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEnemy‚Ì
        {
            Destroy(this.gameObject);
        }
    }
}
