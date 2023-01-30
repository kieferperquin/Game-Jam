using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject gameStart;
    public GameObject winScreen;
    public GameObject loseScreen;

    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        gameStart.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void menu()
    {
        Time.timeScale = 0f;
        gameStart.SetActive(true);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
}
