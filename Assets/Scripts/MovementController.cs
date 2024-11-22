using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 5f;

    private Vector3 moveDirection;

    public event Action pickupEvent;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update(){

        moveDirection = Vector3.zero;

        if(Input.GetKey(KeyCode.A)){
            moveDirection += new Vector3(0,0,-1);
        }
        if(Input.GetKey(KeyCode.D)){
            moveDirection += new Vector3(0,0,1);
        }
        if(Input.GetKey(KeyCode.W)){
            moveDirection += new Vector3(-1,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            moveDirection += new Vector3(1,0,0);
        }

        moveDirection.Normalize();
    }

    void FixedUpdate(){
        rb.AddForce(moveDirection * thrust);
    }

    public void AddPoint(){
        pickupEvent();
    }
}
