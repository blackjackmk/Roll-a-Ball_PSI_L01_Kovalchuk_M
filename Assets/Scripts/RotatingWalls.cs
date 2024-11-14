using UnityEngine;

public class RotatingWalls : MonoBehaviour
{

    public GameObject center;
    public int speed = 10;
    public int Right = 1;
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 10 * Time.deltaTime, 0, Space.World);
        //transform.position += new Vector3(4.5f, 0, -0.8f) * Time.deltaTime;
        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime * Right);
    }
}
