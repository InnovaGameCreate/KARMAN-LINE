using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contract1 : MonoBehaviour
{
    [SerializeField] private GameObject expPrefab;
    [SerializeField] private float lifetime;
    private GameObject exp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            Instantiate(expPrefab, transform.position, expPrefab.transform.rotation);
        }

    }

}
