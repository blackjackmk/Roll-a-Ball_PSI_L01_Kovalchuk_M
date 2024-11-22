using UnityEngine;

public class RotatingWalls : MonoBehaviour
{

    public GameObject center;
    public int speed = 10;
    public int Right = 1;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime * Right);
    }
}
