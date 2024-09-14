using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemy : MonoBehaviour
{
    public float lagTime = 1.0f; // �����x������
    public float makeTime = 1.0f; // �e�𔭎˂��鎞�ԊԊu
    private float waitTime = 5; // ���݂̑ҋ@����
    private bool firstShot = true; // ���߂Ă̒e���˂��ǂ����̃t���O

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = lagTime; // �����ҋ@���Ԃ�ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if (firstShot)
        {
            // ���񔭎˂܂ł̑ҋ@���Ԃ��o�߂����ꍇ
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                firstShot = false; // ���񔭎˃t���O������
                waitTime = 0; // ���ˌ�̑ҋ@���Ԃ����Z�b�g
            }
        }
        else
        {
            // ���ˊԊu���Ǘ�
            if (waitTime < makeTime)
            {
                waitTime += Time.deltaTime;
            }
            else
            {
                // �e�𔭎�
                Instantiate(bulletPrefab, new Vector3(20, 1, 0), bulletPrefab.transform.rotation);
                waitTime = 0; // �ҋ@���Ԃ����Z�b�g
            }
        }
    }
}
