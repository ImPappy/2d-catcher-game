using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpspeed = 5f;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        

        if (Input.GetKeyDown("space") && isTouchingGround)
        {
            player.velocity = new Vector3(0, jumpspeed, 0);
        } 
    }
}
