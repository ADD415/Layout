using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text life;
    int lives = 3;
    private float time = 0;
    public int playerScore = 0;
    public GameObject playerScoreUI;
    public GameObject timeUI;
    public Spawner Spawner;


    void Update()
    {
        time += Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)time);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
    }

    public void lifeLost()
    {
        lives--;
        life.text = lives.ToString();
    }

    public void Score_increase()
    {
        playerScore += 10;
    }

    public void checkLives()
    {
        if (lives < 4)
        {
            Spawner.CheckValue();
        }
        else
        {
            Spawner.spawnPlayer();
        }
    }

    public void livesTransfer()
    {
        PlayerPrefs.SetInt("lives", lives);
    }
}


