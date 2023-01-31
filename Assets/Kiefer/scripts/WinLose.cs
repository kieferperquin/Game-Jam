using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;

    public void Win()
    {
        Time.timeScale = 0f;
        winScreen.SetActive(true);
    }
    public void Lose()
    {
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
    }
}
