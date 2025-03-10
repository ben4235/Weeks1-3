using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncingBall : MonoBehaviour
{
    float speedX = 0.1f;
    float speedY = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speedX;
        pos.y += speedY;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {

            speedY = speedY * -1;
        }
        transform.position = pos;

    }
}
