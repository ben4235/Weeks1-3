using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [Range(0, 1)]
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(0, 0, 0); // The point around which the object will rotate
        transform.RotateAround(point, Vector3.forward, -speed); // Rotate around the point on the z-axis
    }
}
