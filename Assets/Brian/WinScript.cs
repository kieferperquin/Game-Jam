using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject menuScreen;
    bool winCondition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winCondition = Player.GetComponent<Movement>().WinCondition();

        if (winCondition == true)
        {
            menuScreen.GetComponent<WinLose>().Win();
        }
    }
}
