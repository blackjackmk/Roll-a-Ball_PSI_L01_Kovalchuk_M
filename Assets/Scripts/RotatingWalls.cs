using UnityEngine;

public class RotatingWalls : MonoBehaviour
{

    public GameObject center;
    private int speed = 10;
    public int right = 1;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime * right);
    }
}
