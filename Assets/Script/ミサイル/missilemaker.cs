using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bulletmaker : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private float lifetime;
    public float fireCooldown = 5f; // ���˂ł��Ȃ����ԁi�b�j
    [SerializeField] private GameObject explosionPrefab;
    private GameObject explosion;
    private Rigidbody rb;

    private bool canShoot = true;   // ���ˉ\���ǂ������Ǘ�����t���O

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
        // �e�𔭎˂��鏈��
        explosion = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);

        rb = explosion.GetComponent<Rigidbody>();
        Vector3 force1 = new Vector3(1.0f, 0.0f, 0.0f);
        rb.AddForce(force1 * bulletspeed);

        Destroy(explosion, lifetime);

        canShoot = false; // ���˂ł��Ȃ��悤�ɐݒ�

        // �w�莞�Ԍ�ɍĂє��ˉ\�ɂ���
        Invoke("ResetShoot", fireCooldown);
}

void ResetShoot()
{
    canShoot = true; // ���ˉ\�ɖ߂�
}
}