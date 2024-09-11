using System.Collections;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    // 状態を管理するフラグ
    private bool isCharging = false;
    private bool isCooldown = false;

    // レーザー発射サイクルのタイミング
    public float startDelay = 3f;      // ゲーム開始後の遅延
    public float chargeTime = 5f;      // レーザーの溜め時間
    public float cooldownTime = 6f;    // クールタイムの時間

    void Start()
    {
        // サイクルを開始するコルーチンを呼び出す
        StartCoroutine(LaserCycle());
    }

    IEnumerator LaserCycle()
    {
        // ゲーム開始後の遅延
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // 溜め始める
            isCharging = true;
            Debug.Log("Laser charging started...");

            // 溜め時間を待つ
            yield return new WaitForSeconds(chargeTime);

            // レーザー発射
            isCharging = false;
            Debug.Log("Laser fired!");

            // クールダウンを開始
            isCooldown = true;
            yield return new WaitForSeconds(cooldownTime);

            // クールダウン終了
            isCooldown = false;
            Debug.Log("Cooldown finished, ready to start cycle again.");
        }
    }
}
