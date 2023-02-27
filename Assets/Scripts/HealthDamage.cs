using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthDamage : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float waterDamage;


    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("you have died");
            SceneManager.LoadScene("Die Screen");
        }

        if(transform.position.y <= -10)
        {
            Debug.Log("you have died");
            SceneManager.LoadScene("Die Screen");
        }
    }

    public float GetHealth()
    {
        return health;
    }


    public void WaterDamage()
    {
        health = health - waterDamage;
    }
}
