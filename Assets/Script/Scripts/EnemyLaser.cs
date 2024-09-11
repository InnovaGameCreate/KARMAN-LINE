using System.Collections;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    // ��Ԃ��Ǘ�����t���O
    private bool isCharging = false;
    private bool isCooldown = false;

    // ���[�U�[���˃T�C�N���̃^�C�~���O
    public float startDelay = 3f;      // �Q�[���J�n��̒x��
    public float chargeTime = 5f;      // ���[�U�[�̗��ߎ���
    public float cooldownTime = 6f;    // �N�[���^�C���̎���

    void Start()
    {
        // �T�C�N�����J�n����R���[�`�����Ăяo��
        StartCoroutine(LaserCycle());
    }

    IEnumerator LaserCycle()
    {
        // �Q�[���J�n��̒x��
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // ���ߎn�߂�
            isCharging = true;
            Debug.Log("Laser charging started...");

            // ���ߎ��Ԃ�҂�
            yield return new WaitForSeconds(chargeTime);

            // ���[�U�[����
            isCharging = false;
            Debug.Log("Laser fired!");

            // �N�[���_�E�����J�n
            isCooldown = true;
            yield return new WaitForSeconds(cooldownTime);

            // �N�[���_�E���I��
            isCooldown = false;
            Debug.Log("Cooldown finished, ready to start cycle again.");
        }
    }
}
