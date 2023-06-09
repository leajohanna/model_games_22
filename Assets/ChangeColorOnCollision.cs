using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                Color newColor = Random.ColorHSV(); // Generate a random color
                renderer.material.color = newColor;
            }
        }
    }
}
