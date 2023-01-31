using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    bool open = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject doorOpenMinigame;
    static GameObject sameObj;
    void Update()
    {
        if (gameObject != sameObj)
        {
            open = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;

            var tempAlp = gameObject.GetComponent<SpriteRenderer>().color;
            tempAlp.a = 1f;
            gameObject.GetComponent<SpriteRenderer>().color = tempAlp;
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            open = true;

            var tempAlp = gameObject.GetComponent<SpriteRenderer>().color;
            tempAlp.a = 0.5f;
            gameObject.GetComponent<SpriteRenderer>().color = tempAlp;
        }
    }
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
        sameObj = gameObject;
        player.GetComponent<Movement>().ResumeMoving();
    }
    public void OpenFail()
    {
        player.GetComponent<InDanger>().InDangerStart();
        sameObj = gameObject;
    }
    public void DrawerOpen()
    {
        player.GetComponent<Movement>().ReverseDirection();
        //activate cutscene
    }
    public void PlayerLoses()
    {
        player.GetComponent<InDanger>().YouLost();
    }
}
