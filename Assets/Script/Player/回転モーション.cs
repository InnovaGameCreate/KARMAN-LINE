using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class �ۑ� : MonoBehaviour
{
    bool coroutineBool = false;
    public float cooltime;
    private float cool;
    // Start is called before the first frame update

    void Start()
    {
        cooltime = 1f;
        cool = 0;
    }

    IEnumerator RightMove()
    {

        for (int turn = 0; turn < 360; turn++)
        {
            transform.Rotate(1, 0, 0);
            yield return new WaitForSeconds(0.0001f);
        }
        coroutineBool = false;

    }
    //Update is called once per flame
    private void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {

            //��]���ł͂Ȃ��N�[���^�C���ȏ�̏ꍇ�͎��s 
            if (!coroutineBool && cool < Time.time)
            {
                cool = Time.time + cooltime;
                coroutineBool = true;
                StartCoroutine("RightMove");
            }
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        // �Փ˂������̂�Rigidbody�R���|�[�l���g���擾
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // �Փ˂������̂�X�x�N�g���𔽓]
            rb.velocity = new Vector3(-rb.velocity.x, rb.velocity.y, rb.velocity.z);
        }
    }
}