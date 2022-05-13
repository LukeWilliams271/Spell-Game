using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public CombatObject tileObject;
    public CombatMaster cMaster; 

    //interaction states
    public bool mouseHovering;
    public bool selected;

    // Start is called before the first frame update
    void Start()
    {
        cMaster = GetComponentInParent<CombatMapScript>().cMaster;     
    }

    // Update is called once per frame
    void Update()
    {
        if (cMaster.selectedTiles.Contains(this))
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (tileObject != null)
        {
            if (tileObject.transform.position != transform.position)
            {
                tileObject.transform.position = transform.position;
            }
        }
        
    }

    private void OnMouseEnter()
    {
        mouseHovering = true;
        GetComponent<SpriteRenderer>().color = Color.grey;
    }
    private void OnMouseExit()
    {
        mouseHovering = true;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void OnMouseDown()
    {
        SelectTile();
    }

    void SelectTile()
    {
        cMaster.selectedTiles.Add(this);
    }
}
