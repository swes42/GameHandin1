using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Transform playerPos;

    public Transform enemy;

    public float distanceToGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This ain't great for more than one enemy. Whoops.
        if(Vector3.Distance(playerPos.position, enemy.position)<= distanceToGameOver)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            gameOverScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
