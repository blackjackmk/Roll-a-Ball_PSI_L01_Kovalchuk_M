using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{ 
    private UnityEngine.Vector3 diff_vector;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //A = B - C
        diff_vector = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //C = B - A
        transform.position = player.position - diff_vector;
    }
}
