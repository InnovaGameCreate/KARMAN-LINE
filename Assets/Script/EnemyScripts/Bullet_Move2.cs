using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move2 : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float LifeTime;

    // Start is called before the first frame update
    void Start()
    {
        SpeedX = Random.Range(SpeedX - 5, SpeedX);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime); //�G���������ɗ����Ă���

        //enemyLifeTime���t���[���Ԃ̎��Ԃ�����������
        LifeTime = LifeTime - Time.deltaTime;
        if (LifeTime < 0)
        {
            Destroy(this.gameObject);//���̃I�u�W�F�N�g���폜
        }

    }
}
