using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private AudioSource audioSource;
    private ParticleSystem particle;
    private Color uncollectedColor = new Color(0.5f, 0.5f, 0.5f, 1.0f);
    private Color collectedColor = new Color(0.5f, 0.5f, 0.5f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        particle = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider collider){
        collider.gameObject.GetComponent<MovementController>().AddPoint();
        particle.Play();
        audioSource.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        Invoke(nameof(DestroyCollectible), 1.3f);
    }

    private void DestroyCollectible(){
        gameObject.SetActive(false);
    }
}
