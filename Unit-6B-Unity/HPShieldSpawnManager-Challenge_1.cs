using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPShieldSpawnManager : MonoBehaviour
{
    public GameObject hpshieldPrefab;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        Debug.Log("my favorite character is DEKU!!");   // Trouble shooting method to see if script works.
        InvokeRepeating("SpawnHPShield", startDelay, spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {

    }


    void SpawnHPShield()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(hpshieldPrefab, spawnPos, hpshieldPrefab.transform.rotation);  // Spawns a HP Shield game object at a random location on the X Axis. 
    }
}