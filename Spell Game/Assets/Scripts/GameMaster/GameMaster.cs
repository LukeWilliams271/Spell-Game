using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public bool inCombat = false;
    public GameObject combatScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCombat()
    {
        inCombat = true;
        combatScreen.SetActive(true);
    }
    public void EndCombat()
    {

    }
}
