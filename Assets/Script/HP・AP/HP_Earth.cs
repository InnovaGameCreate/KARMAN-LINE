using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider HPBar; // �X���C�_�[�̎Q��
    public float maxHP = 100f;
    private float currentHP;

    private bool invulnerable = false; // ���G��ԃt���O
    private float invulnerabilityDuration = 2f; // ���G��Ԃ̎�������
    private float invulnerabilityTimer = 0f; // �^�C�}�[

    private bool canInvulnerable = true; // ���G��Ԃ𔭓��ł��邩�ǂ����̃t���O
    private float invulnerabilityCooldown = 5f; // ���G��Ԃ̃N�[���_�E������
    private float cooldownTimer = 0f; // �N�[���_�E���^�C�}�[

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;

        if (HPBar != null)
        {
            HPBar.value = maxHP;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ���G��Ԃ̃^�C�}�[���X�V
        if (invulnerable)
        {
            invulnerabilityTimer -= Time.deltaTime;
            if (invulnerabilityTimer <= 0)
            {
                invulnerable = false;
                cooldownTimer = invulnerabilityCooldown; // �N�[���_�E���^�C�}�[���J�n
                canInvulnerable = false; // ���G��Ԃ̍Ĕ�����h��
            }
        }

        // �N�[���_�E���^�C�}�[���X�V
        if (!canInvulnerable)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0)
            {
                canInvulnerable = true; // �N�[���_�E���I��
            }
        }

        // S�L�[�������ꂽ�Ƃ��A�N�[���_�E�����I����Ă���Ζ��G��Ԃɂ���
        if (Input.GetKeyDown(KeyCode.S) && canInvulnerable)
        {
            invulnerable = true;
            invulnerabilityTimer = invulnerabilityDuration;
            canInvulnerable = false; // ���G��Ԃ𔭓������̂ōĔ�����h��
        }
    }
    public void TakeDamage(float damage)
    {
        if (invulnerable) return; // ���G��ԂȂ�_���[�W�𖳌���

        currentHP -= damage;
        if (HPBar != null)
        {
            HPBar.value = currentHP;
        }

        if (currentHP <= 0)
        {
            Die();
        }
    }

    
    void Die()
    {
        SceneManager.LoadScene("Failure");
    }



}
