using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;



public class PlayerMovement : MonoBehaviour

{
    public float movespeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is for left and right movements
    Vector3 pos = transform.position;

        if (Input.GetKey("d"))
        {
            pos.x += movespeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= movespeed * Time.deltaTime;
        }

        

        transform.position = pos;

    }

        
    
}
