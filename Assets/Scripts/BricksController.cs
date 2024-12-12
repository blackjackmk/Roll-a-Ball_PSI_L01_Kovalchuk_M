using UnityEditor.Callbacks;
using UnityEngine;

public class BricksController : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Rigidbody>().mass >= 10.00f)
        {
            rb.constraints = RigidbodyConstraints.None;
        }else if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<Rigidbody>().mass < 10.00f)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
