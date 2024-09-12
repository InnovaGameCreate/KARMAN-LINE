using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider HPBar; // スライダーの参照
    public float maxHP = 100f;
    private float currentHP;

    private bool invulnerable = false; // 無敵状態フラグ
    private float invulnerabilityDuration = 2f; // 無敵状態の持続時間
    private float invulnerabilityTimer = 0f; // タイマー

    private bool canInvulnerable = true; // 無敵状態を発動できるかどうかのフラグ
    private float invulnerabilityCooldown = 5f; // 無敵状態のクールダウン時間
    private float cooldownTimer = 0f; // クールダウンタイマー

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
        // 無敵状態のタイマーを更新
        if (invulnerable)
        {
            invulnerabilityTimer -= Time.deltaTime;
            if (invulnerabilityTimer <= 0)
            {
                invulnerable = false;
                cooldownTimer = invulnerabilityCooldown; // クールダウンタイマーを開始
                canInvulnerable = false; // 無敵状態の再発動を防ぐ
            }
        }

        // クールダウンタイマーを更新
        if (!canInvulnerable)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0)
            {
                canInvulnerable = true; // クールダウン終了
            }
        }

        // Sキーが押されたとき、クールダウンが終わっていれば無敵状態にする
        if (Input.GetKeyDown(KeyCode.S) && canInvulnerable)
        {
            invulnerable = true;
            invulnerabilityTimer = invulnerabilityDuration;
            canInvulnerable = false; // 無敵状態を発動したので再発動を防ぐ
        }
    }
    public void TakeDamage(float damage)
    {
        if (invulnerable) return; // 無敵状態ならダメージを無効化

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
