using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 10 * Time.deltaTime, 0, Space.World);
    }

    void OnTriggerEnter(Collider collider){
        collider.gameObject.GetComponent<MovementController>().AddPoint();
        gameObject.SetActive(false);
    }
}
