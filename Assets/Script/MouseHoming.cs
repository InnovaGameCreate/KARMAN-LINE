using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 mouse;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        transform.localScale = new Vector3((float)0.01,(float) 0.01,(float) 0.01); // Ç±Ç±Ç≈ÉXÉPÅ[ÉãÇê›íË
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y,2 ));
        this.transform.position = target;
    }

    
}
