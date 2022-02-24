using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [HideInInspector]
    public Collider2D playerCollider;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");    
    }
}
