using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            transform.localScale *= 1.2f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale *= 0.8f;
        }
        if( Input.GetKeyDown(KeyCode.RightArrow))
        {
            speedX *= 1.2f;
            speedY *= 1.2f;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speedX *= 0.8f;
            speedY *= 0.8f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);

                speedY = Random.Range(-1f, 1f); // Random float between -1 and 1
                speedX = Random.Range(-1f, 1f); // Random float between -1 and 1

        }

    }
}
