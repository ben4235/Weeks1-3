using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceInvader : MonoBehaviour
{
    // Speed at which the invader moves downward
    float speed = -0.01f;

    void Start()
    {
        // Find the top of the screen in world coordinates
        // Viewport coordinates range from (0,0) at bottom-left to (1,1) at top-right
        // (0.5, 1, 0) means the middle at the top of the screen
        float screenTop = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1, 0)).y;

        // Generate a random X position within a range so invaders don't always spawn in the same place
        float randomX = Random.Range(-7f, 7f); // Adjust these values based on your game’s width

        // Set the invader's starting position at the top of the screen with a random X position
        transform.position = new Vector3(randomX, screenTop, 0);
    }

    void Update()
    {
        // Get the current position of the invader
        Vector3 pos = transform.position;

        // Move the invader downward by modifying the Y position
        pos.y += speed;

        // Apply the new position back to the object
        transform.position = pos;
    }
}
