using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 5f;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            //rb.AddForce(0, 0, -thrust,ForceMode.Impulse);
            //rb.AddForce(Vector3.left * thrust);
            rb.AddForce(new Vector3(0,0,-1) * thrust);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(new Vector3(0,0,1) * thrust);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(new Vector3(-1,0,0) * thrust);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(new Vector3(1,0,0) * thrust);
        }
        if(Input.GetButtonUp("Jump")){
            rb.AddForce(new Vector3(0,1,0) * thrust);
        }

    }

    public void AddPoint(){
        score += 1;
        Debug.Log(score+"/6");
    }
}
