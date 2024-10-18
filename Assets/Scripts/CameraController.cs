using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //public MovementController playerController; 

    UnityEngine.Vector3 diff_vector;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = player.transform.position + new UnityEngine.Vector3(0, 100, -100);

        //playerController.transform.position = transform.position;

        UnityEngine.Vector3 diff_vector = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - diff_vector;
    }
}
