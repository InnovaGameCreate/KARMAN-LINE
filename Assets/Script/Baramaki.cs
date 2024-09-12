using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baramaki : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float lagTime;
    [SerializeField] private float bulletX;
    [SerializeField] private float bulletY;
    [SerializeField] private float bulletZ;
    private Vector3 posi;
    private int a;
    private float ranX;
    private float ranZ;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = lagTime;
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
            a = 0;
            while (a < 5)
            {
                ranX = Random.Range(bulletX, bulletX + 3);
                ranZ = Random.Range(bulletZ * -1, bulletZ);
                Instantiate(bulletPrefab, new Vector3(ranX , 5, ranZ), bulletPrefab.transform.rotation);
                a++;
            }
            waitTime = 0;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(this.gameObject);
    }
}
