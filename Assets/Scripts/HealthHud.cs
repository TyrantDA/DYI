using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHud : MonoBehaviour
{
    public Image HealthBar;
    public HealthDamage player;
    private float maxHealth;
    private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = player.GetHealth();
        currentHealth = player.GetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = player.GetHealth();
        HealthBar.fillAmount = currentHealth / maxHealth; 
    }
}
