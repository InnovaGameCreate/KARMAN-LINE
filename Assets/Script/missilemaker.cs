using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bulletmaker : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private float lifetime;
    [SerializeField] private GameObject explosionPrefab;
    private GameObject explosion;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            explosion = Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);

            rb = explosion.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletspeed);

            Destroy(explosion, lifetime);
        }
    }
}