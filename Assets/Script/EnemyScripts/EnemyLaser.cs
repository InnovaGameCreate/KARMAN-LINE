using System.Collections;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private float makeTime;
        private float waitTime;
        [SerializeField] private float lagTime;
        private Vector3 posi;
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
                Instantiate(bulletPrefab, new Vector3(22, 5, 0), bulletPrefab.transform.rotation);
                waitTime = 0;
            }
        }
    }
