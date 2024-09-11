using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3way : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab1;
    [SerializeField] private GameObject bulletPrefab2;
    [SerializeField] private GameObject bulletPrefab3;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float lagTime;
    private Vector3 posi;
    // Start is called before the first frame update
    void Start()
    {
        waitTime += lagTime;
    }

    // Update is called once per frame
    void Update()
    {
        posi = this.transform.position;

        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }
        else
        {
            Instantiate(bulletPrefab1, new Vector3(posi.x, posi.y, posi.z), bulletPrefab1.transform.rotation);
            Instantiate(bulletPrefab2, new Vector3(posi.x, posi.y, posi.z), bulletPrefab2.transform.rotation);
            Instantiate(bulletPrefab3, new Vector3(posi.x, posi.y, posi.z), bulletPrefab3.transform.rotation);
            waitTime = 0;
        }
    }
}
