using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameMaster master;
    public float moveSpeed = 0.5f;
    public Transform movePoint;

    public LayerMask enemiesLayer;
    public LayerMask obsticalsLayer;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0), 0.1f, enemiesLayer))
                {
                    master.StartCombat();
                } else if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0), 0.1f, obsticalsLayer))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
                } 
            } else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (Physics2D.OverlapCircle(movePoint.position + new Vector3(0, Input.GetAxisRaw("Vertical"), 0), 0.1f, enemiesLayer))
                {
                    master.StartCombat();
                }
                else if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0, Input.GetAxisRaw("Vertical"), 0), 0.1f, obsticalsLayer))
                {
                    movePoint.position += new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
                }
            }
        }
    }
    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movementVector * moveSpeed * Time.fixedDeltaTime);
          
    }
}
