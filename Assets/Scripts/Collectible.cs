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

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 10 * Time.deltaTime, 0, Space.World);
    }

    void OnTriggerEnter(Collider collider){
        collider.gameObject.GetComponent<MovementController>().AddPoint();
        audioSource.Play();
        Invoke(nameof(DestroyCollectible), 1.3f);
    }

    private void DestroyCollectible(){
        gameObject.SetActive(false);
    }
}
