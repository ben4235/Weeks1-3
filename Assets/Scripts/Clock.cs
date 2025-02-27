using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [Range(0, 0.02f)]
    public float hour_speed;
    public float minute_speed;

    public Transform Hour_Hand;  // Reference to the hour hand object
    public Transform Minute_Hand;  // Reference to the minute hand object

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set the minute speed based on hour speed at the start
        minute_speed = hour_speed * 12;


        Vector3 point = new Vector3(0, 0, 0); // The point around which the object will rotate
        Hour_Hand.RotateAround(point, Vector3.forward, -hour_speed); // Rotate around the point on the z-axis
        Minute_Hand.RotateAround(point, Vector3.forward, -minute_speed); // Rotate around the point on the z-axis

    }
}
