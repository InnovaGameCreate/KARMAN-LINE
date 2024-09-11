using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BulletMove2 : MonoBehaviour
{
    [SerializeField] private float bullet2Speed;
    [SerializeField] private float lifeTime2;
    [SerializeField] private GameObject bullet2Prefab;
    private GameObject bullet2;
    private Rigidbody rb2;
    private int Gage = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ScoreUp()
    {
        if (Gage < 10)
        {
            Gage += 1;
        }

        if (Gage > 10)
        {
            Gage = Gage - 1;
        }
    }
    public int GetScore()
    {
        return Gage;
    }
    // Update is called once per frame
    void Update()
    {
        if (Gage == 10)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                bullet2 = Instantiate(bullet2Prefab, transform.position, bullet2Prefab.transform.rotation);

                rb2 = bullet2.GetComponent<Rigidbody>();
                rb2.AddForce(transform.forward * bullet2Speed);

                Destroy(bullet2, lifeTime2);

                Gage = Gage - 10;
            }
        }
        if (Gage > 10)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("ÉQÅ[ÉWÇ™ë´ÇËÇƒÇ¢Ç‹ÇπÇÒ");
            }
        }


    }
}