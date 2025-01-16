using UnityEngine;

public class WaterController : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "Player" && other.gameObject.GetComponent<Rigidbody>().mass > 1.00f)
        {
            rb.AddForce(Vector3.down * 10);
        }else{
            rb.AddForce(Vector3.up * 10);
        }
    }
}
