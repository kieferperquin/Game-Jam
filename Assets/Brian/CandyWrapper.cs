using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyWrapper : MonoBehaviour
{
    GameObject player;
    static GameObject mostRecent;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == player.name)
        {
            if (gameObject == mostRecent)
            {
                Debug.Log("sameObj");
            }
            else
            {
                player.GetComponent<Movement>().PauseMoving();
                player.GetComponent<InDanger>().InDangerStart();
                mostRecent = gameObject;
            }
        }
    }
}
