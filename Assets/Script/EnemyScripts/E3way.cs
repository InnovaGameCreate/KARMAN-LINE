using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3way : MonoBehaviour
{
    public float lagTime = 1.0f; // �����x������
    public float makeTime = 1.0f; // �e�𔭎˂��鎞�ԊԊu
    private float waitTime = 5; // ���݂̑ҋ@����
    private bool firstShot = true; // ���߂Ă̒e���˂��ǂ����̃t���O

    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

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
                Instantiate(bulletPrefab1, new Vector3(22, 1, 5), bulletPrefab1.transform.rotation);
                Instantiate(bulletPrefab2, new Vector3(22, 1, 0), bulletPrefab2.transform.rotation);
                Instantiate(bulletPrefab3, new Vector3(22, 1, -5), bulletPrefab3.transform.rotation);
                waitTime = 0; // �ҋ@���Ԃ����Z�b�g
            }
        }
    }
}
