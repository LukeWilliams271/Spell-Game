using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatObject : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public int maxEnergy;
    public int energy;

    public PlayerCombatScript playerScript;
    private bool isPlayer;

    public EnemyCombatScript enemyScript;
    private bool isEnemy;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        energy = maxEnergy;

        if (playerScript != null)
        {
            isPlayer = true;
            isEnemy = false;
        } else
        {
            isPlayer = false;
            isEnemy = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
        {

        }
    }

    // returns true if the spell is able to go through, i.e. character has enough energy
    public bool SpendEnergy(int value)
    {
        if (energy >= value)
        {
            energy -= value;
            return true;
        } else
        {
            return false;
        }
    }

    public void Die()
    {

    }
}
