using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 mouse;
    private Vector3 target;
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 80;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        transform.position += transform.forward * speed;
    }
}
