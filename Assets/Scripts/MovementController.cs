using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;
    private Material material;
    public Material rock_material;
    public Material volley_material;
    public float thrust = 5f;

    private Vector3 moveDirection;

    public event Action pickupEvent;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        material = GetComponent<Renderer>().material;
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
        if(Input.GetKey(KeyCode.Alpha1)){//default
            rb.mass = 5.0f;
            GetComponent<MeshRenderer> ().material = material;
        }
        if(Input.GetKey(KeyCode.Alpha2)){//rock
            rb.mass = 30.0f;
            GetComponent<MeshRenderer> ().material = rock_material;
            
        }
        if(Input.GetKey(KeyCode.Alpha3)){//volley
            rb.mass = 1.0f;
            GetComponent<MeshRenderer> ().material = volley_material;
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
