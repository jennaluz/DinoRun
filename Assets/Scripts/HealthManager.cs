using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmt = 100f;
    // Start is called before the first frame update
    private void Start()
    {
        healthAmt = 100f;
    }

    // Update is called once per frame

    public void TakeDamage(float damage)
    {
        healthAmt -= damage;
        healthBar.fillAmount = healthAmt / 100f;

        if(healthAmt <= 0)
        {
            healthAmt = 0;
            Debug.Log("YOU'RE DEAD!");
        }
    }

}
