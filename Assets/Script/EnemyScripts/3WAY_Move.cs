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
        transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime); //敵が下方向に落ちてくる

        //enemyLifeTimeをフレーム間の時間を減少させる
        moveLifeTime = moveLifeTime - Time.deltaTime;
        if (moveLifeTime < 0)
        {
            Destroy(this.gameObject);//このオブジェクトを削除
        }

    }
}
