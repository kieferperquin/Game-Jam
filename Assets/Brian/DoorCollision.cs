using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    bool open = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject doorOpenMinigame;

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
        GameObject doorminigame = Instantiate(doorOpenMinigame);
        doorminigame.transform.position = transform.position;
        doorminigame.GetComponent<DoorOpening>().SpawnParent(gameObject);
    }
    public void OpenSuccesfull()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        open = true;
    }
}
