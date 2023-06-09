using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Get the cursor position in world space
        Vector3 cursorPosition = GetCursorPosition();

        // Calculate the direction from the player to the cursor position
        Vector3 moveDirection = cursorPosition - transform.position;
        moveDirection.y = 0f; // Lock the movement on the y-axis (optional)

        // Normalize the direction vector and move the player
        if (moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody>().AddForce(moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    private Vector3 GetCursorPosition()
    {
        // Cast a ray from the cursor position into the world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if the ray hits any colliders in the scene
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // Return the point where the ray hits a collider
            return hit.point;
        }

        // If the ray doesn't hit anything, return the cursor position in the world
        return ray.GetPoint(0);
    }
}
