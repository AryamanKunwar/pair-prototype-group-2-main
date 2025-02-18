using UnityEngine;

public class CrystalDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that hit is tagged as "Ball"
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject); // Remove the crystal from the scene
        }
    }
}
