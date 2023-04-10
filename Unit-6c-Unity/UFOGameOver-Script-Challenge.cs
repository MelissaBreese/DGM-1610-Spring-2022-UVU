using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOGameOver : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip ufoGameover;
    public AudioSource gameOver;
    public AudioSource playerAudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UFO"))
        {
            gameManager.isGameOver = true;
            playerAudio.PlayOneShot(ufoGameover, 1.0f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}