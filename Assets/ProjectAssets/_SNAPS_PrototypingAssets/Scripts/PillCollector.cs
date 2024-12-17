using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);


            // Notify the GameManager to add points
            GameManager.instance.AddPoint();
            
            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
