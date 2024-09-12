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
            // ƒ_ƒ[ƒW‚ğ—^‚¦‚é
            health.TakeDamage(damageAmount);
        }

        if (collision.gameObject.CompareTag("Earth"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEnemy‚Ì
         {
            Destroy(this.gameObject);
         }

        if (collision.gameObject.CompareTag("Bullet_E"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Laser"))//collision‚É“ü‚Á‚Ä‚¢‚éTag‚ªEarth‚Ì
        {
            Destroy(this.gameObject);
        }
    }
}
