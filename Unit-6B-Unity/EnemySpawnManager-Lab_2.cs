using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO Ships.
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            int ufoIndex = Random.Range(0,ufoPrefabs.Length);  // Picks a random UFO from the array.
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 15), ufoPrefabs[ufoIndex].transform.rotation);  // Spawns an Indexed UFO from the array
        }
    }
}
