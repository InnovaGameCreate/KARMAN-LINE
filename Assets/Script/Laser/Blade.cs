using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private GameObject bullet;
    public GameObject bulletPrefab; // 弾のプレハブ
    public float fireCooldown = 5f; // 発射できない時間（秒）
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    private Rigidbody rb;

    private bool canShoot = true;   // 発射可能かどうかを管理するフラグ

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && canShoot)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 弾を発射する処理
        bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        rb = bullet.GetComponent<Rigidbody>(); 

        Vector3 force1 = new Vector3(1.0f, 0.0f, 0.0f);
        rb.AddForce(force1 * bulletSpeed);
        Destroy(bullet, lifeTime);

        canShoot = false; // 発射できないように設定

        // 指定時間後に再び発射可能にする
        Invoke("ResetShoot", fireCooldown);
    }

    void ResetShoot()
    {
        canShoot = true; // 発射可能に戻す
    }
}  

