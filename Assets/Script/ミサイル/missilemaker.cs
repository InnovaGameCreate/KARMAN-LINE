using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bulletmaker : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private float lifetime;
    public float fireCooldown = 5f; // 発射できない時間（秒）
    [SerializeField] private GameObject explosionPrefab;
    private GameObject explosion;
    private Rigidbody rb;

    private bool canShoot = true;   // 発射可能かどうかを管理するフラグ

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && canShoot)
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        // 弾を発射する処理
        explosion = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);

        rb = explosion.GetComponent<Rigidbody>();
        Vector3 force1 = new Vector3(1.0f, 0.0f, 0.0f);
        rb.AddForce(force1 * bulletspeed);

        Destroy(explosion, lifetime);

        canShoot = false; // 発射できないように設定

        // 指定時間後に再び発射可能にする
        Invoke("ResetShoot", fireCooldown);
}

void ResetShoot()
{
    canShoot = true; // 発射可能に戻す
}
}