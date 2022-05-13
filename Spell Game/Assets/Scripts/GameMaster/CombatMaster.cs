using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMaster : MonoBehaviour
{
    public List<Tile> selectedTiles;

    public Spell heldSpell;

    public Spell[] equippedSpells = new Spell[9];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearSelectedTiles()
    {
        selectedTiles.Clear();
    }

    public void PlaceSpellInPointer(int spellEquipIndex)
    {
        if (equippedSpells[spellEquipIndex] != null) heldSpell = equippedSpells[spellEquipIndex];
        ClearSelectedTiles();
    }
}
