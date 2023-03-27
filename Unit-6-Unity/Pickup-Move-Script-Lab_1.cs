using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMove : MonoBehaviour
{
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // Move pickup game object forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
