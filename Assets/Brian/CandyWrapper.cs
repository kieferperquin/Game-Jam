using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyWrapper : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == player.name)
        {
            player.GetComponent<Movement>().PauseMoving();
            player.GetComponent<InDanger>().InDangerStart();
        }
    }
}
