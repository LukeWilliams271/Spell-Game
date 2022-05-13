using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCreator : MonoBehaviour
{
    public CombatMaster cMaster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Spell spell = ScriptableObject.CreateInstance<Spell>();
            spell.color = Color.magenta;
            cMaster.equippedSpells[1] = spell;
        }   
    }
}
