using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    bool open = false;
    [SerializeField] GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!open)
        {
            player.GetComponent<Movement>().PauseMoving();
            StartOpening();
        }
    }
    void StartOpening()
    {

    }
}