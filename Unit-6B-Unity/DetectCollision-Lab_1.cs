using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);  // Destroy this game object, ex lazer bolt bullet.
        Destroy(other.gameObject);  // Destroy other game object, ex UFO lazer bolt hits.
    }
}
