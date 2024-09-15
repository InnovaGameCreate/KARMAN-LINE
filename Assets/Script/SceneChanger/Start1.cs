using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            SceneManager.LoadScene("Main");
        }

        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene("ëÄçÏê‡ñæ");
        }
    }
}
