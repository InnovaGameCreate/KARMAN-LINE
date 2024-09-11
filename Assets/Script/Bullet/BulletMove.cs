using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
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
            if (Input.GetKey(KeyCode.Space))
            {
                bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);

                rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * bulletSpeed);

                Destroy(bullet, lifeTime);
                time = 0;
            }

        }
    }

}