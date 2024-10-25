using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public GameObject player; 

    private UnityEngine.Vector3 diff_vector;

    // Start is called before the first frame update
    void Start()
    {

        //A = B - C
        diff_vector = player.transform.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        //C = B - A
        transform.position = player.transform.position - diff_vector;
    }
}
