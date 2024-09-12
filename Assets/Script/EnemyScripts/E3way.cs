using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3way : MonoBehaviour
{
    public float lagTime = 1.0f; // 初期遅延時間
    public float makeTime = 1.0f; // 弾を発射する時間間隔
    private float waitTime = 5; // 現在の待機時間
    private bool firstShot = true; // 初めての弾発射かどうかのフラグ

    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = lagTime; // 初期待機時間を設定
    }

    // Update is called once per frame
    void Update()
    {
        if (firstShot)
        {
            // 初回発射までの待機時間を経過した場合
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                firstShot = false; // 初回発射フラグを解除
                waitTime = 0; // 発射後の待機時間をリセット
            }
        }
        else
        {
            // 発射間隔を管理
            if (waitTime < makeTime)
            {
                waitTime += Time.deltaTime;
            }
            else
            {
                // 弾を発射
                Instantiate(bulletPrefab1, new Vector3(22, 1, 5), bulletPrefab1.transform.rotation);
                Instantiate(bulletPrefab2, new Vector3(22, 1, 0), bulletPrefab2.transform.rotation);
                Instantiate(bulletPrefab3, new Vector3(22, 1, -5), bulletPrefab3.transform.rotation);
                waitTime = 0; // 待機時間をリセット
            }
        }
    }
}
