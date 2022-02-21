using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OverworldScreen : MonoBehaviour
{
    public int screenID;

    public OverworldScreenManager manager;

    [System.Serializable]
    public struct NeighborScreens
    {
        public int upID;
        public int downID;
        public int rightID;
        public int leftID;
    }
    public NeighborScreens neighborScreens;


    // Start is called before the first frame update
    void Start()
    {
        if (manager.activeScreenID != screenID)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (manager.activeScreenID != screenID)
       {
            gameObject.SetActive(false);
       } else if (manager.activeScreenID == screenID)
        {
            gameObject.SetActive(true);
        }
    }
}
