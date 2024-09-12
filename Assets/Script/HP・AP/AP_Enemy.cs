using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AP_Enemy : MonoBehaviour
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
            // ƒ_ƒ[ƒW‚ğ—^‚¦‚é
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Earth"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet_P"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Laser"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }
    }
}
