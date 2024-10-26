using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        int points = 10; // Points per target hit
        UnityEngine.Debug.Log("Collision");

        if (collision.CompareTag("Bullet"))
        {
            // Find the ScoreManager and add points
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.AddScore(points);




            // Destroy the target or the bullet itself
           //Destroy(collision.gameObject); 
            //Destroy(gameObject); // Destroy the bullet
        }
    }

}
