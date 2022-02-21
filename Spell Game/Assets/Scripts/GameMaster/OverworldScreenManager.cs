using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldScreenManager : MonoBehaviour
{
    public int activeScreenID;

    [HideInInspector]
    public OverworldScreen activeScreen;

    public enum direction { up, down, left, right }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void SwitchOverworldScreens(string direction)
    {
        if (direction == "up")
        {
            activeScreenID = activeScreen.neighborScreens.upID;
        } else if (direction == "down")
        {
            activeScreenID = activeScreen.neighborScreens.downID;
        }
        else if (direction == "right")
        {
            activeScreenID = activeScreen.neighborScreens.rightID;
        }
        else if (direction == "left")
        {
            activeScreenID = activeScreen.neighborScreens.leftID;
        }
    }
}
