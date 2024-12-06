using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider){
        collider.gameObject.GetComponent<MovementController>().AddPoint();
        audioSource.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        Invoke(nameof(DestroyCollectible), 1.3f);
    }

    private void DestroyCollectible(){
        gameObject.SetActive(false);
    }
}
