using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public bool inCombat = false;
    public bool overworldPause = false;
    public GameObject combatScreen;
    public Camera combatCamera;
    public Camera overworldCamera;

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
        overworldPause = true;
        combatScreen.SetActive(true);
        combatCamera.enabled = true;
        overworldCamera.enabled = false;
    }
    public void EndCombat()
    {
        combatCamera.enabled = false;
        overworldCamera.enabled = true;
    }
}
