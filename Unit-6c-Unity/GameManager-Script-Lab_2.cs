using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");

    } 

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            EndGame();  // Start EndGame method.
        }
        else
            gameOverText.gameObject.SetActive(false);  // Keep UI Text Game Over hidden.
    }
    public void EndGame()
    {
        Debug.Log("Trying to fix game over text when running");
        gameOverText.gameObject.SetActive(true);  // Make Game Over text appear.
        Time.timeScale = 0;  // Freeze Time
    }
}
