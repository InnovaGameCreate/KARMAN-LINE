using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private GameObject bullet;
    public GameObject bulletPrefab; // �e�̃v���n�u
    public float fireCooldown = 5f; // ���˂ł��Ȃ����ԁi�b�j
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    private Rigidbody rb;

    private bool canShoot = true;   // ���ˉ\���ǂ������Ǘ�����t���O

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
        // �e�𔭎˂��鏈��
        bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        rb = bullet.GetComponent<Rigidbody>(); 

        Vector3 force1 = new Vector3(1.0f, 0.0f, 0.0f);
        rb.AddForce(force1 * bulletSpeed);
        Destroy(bullet, lifeTime);

        canShoot = false; // ���˂ł��Ȃ��悤�ɐݒ�

        // �w�莞�Ԍ�ɍĂє��ˉ\�ɂ���
        Invoke("ResetShoot", fireCooldown);
    }

    void ResetShoot()
    {
        canShoot = true; // ���ˉ\�ɖ߂�
    }
}  

