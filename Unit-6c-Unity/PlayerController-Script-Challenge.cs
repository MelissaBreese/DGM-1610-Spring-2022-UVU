using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;
    public GameObject lazerBolt;
    public DetectCollision detectCollisionscript;
    public AudioClip ufoExplosion;
    public AudioSource playerAudio;
    public AudioSource ufoExplosionsource;


    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //  Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //  Keep player in bounds
        //  Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //  Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If spacebar is pressed, fire lazerBolt.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create lazerBolt at the blaster transform postition maintaining the objects rotation.
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
        void OnCollisionEnter(Collision collision)
        { 
                if (collision.gameObject.tag == "UFO")
            {
            playerAudio.PlayOneShot(ufoExplosion, 1.0f);
            }
        }

        // Delete Any object with a trigger that hits the player.
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "UFO")
            {
            Debug.Log("Collision");
            ufoExplosionsource.GetComponent<AudioSource>().enabled = true;
        }
        Destroy(other.gameObject);
        }
    
}
        