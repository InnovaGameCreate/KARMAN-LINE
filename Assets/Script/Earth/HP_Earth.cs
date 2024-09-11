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
        
    }
    public void TakeDamage(float damage)
    {
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
