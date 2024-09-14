using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1Move1 : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private float timeReset;
    private float time = 0;
    private GameObject bullet;
    private Rigidbody rb;

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > timeReset)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);

                rb = bullet.GetComponent<Rigidbody>();
                Vector3 force1 = new Vector3(1.0f, 0.0f, 0.0f);
                rb.AddForce(force1 * bulletSpeed);

                Destroy(bullet, lifeTime);
                time = 0;
            }

        }
    }
}
