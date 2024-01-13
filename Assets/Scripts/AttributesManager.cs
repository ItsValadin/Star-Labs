using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;
    public int attack;


    public void TakeDamage(int damage)
    {
        health -= maxHealth;
        if(health<0)
        {
            Destroy(gameObject);
        }
    }

    
    
}
