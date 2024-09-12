using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float moveLifeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime); //�G���������ɗ����Ă���

        //enemyLifeTime���t���[���Ԃ̎��Ԃ�����������
        moveLifeTime = moveLifeTime - Time.deltaTime;
        if (moveLifeTime < 0)
        {
            Destroy(this.gameObject);//���̃I�u�W�F�N�g���폜
        }

    }
}
