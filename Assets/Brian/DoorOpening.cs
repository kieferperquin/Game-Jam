using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] GameObject winChanceBlock;
    [SerializeField] GameObject pointer;
    [SerializeField] KeyCode stopPointerButton;
    [SerializeField] bool isDrawer = false;
    GameObject parent;
    bool stopPointer;
    float currHeight;
    float randomWinHeight;
    int dir = -5;

    void Start()
    {
        randomWinHeight = Random.Range(-40, 41) / 100f;
        winChanceBlock.transform.localPosition = new Vector3(winChanceBlock.transform.localPosition.x, randomWinHeight, -1);
    }
    void Update()
    {
    
        if (!stopPointer)
        {
            if (pointer.transform.localPosition.y <= -0.5)
            {
                dir = 5;
            }
            else if (pointer.transform.localPosition.y >= 0.5)
            {
                dir = -5;
            }

            if (Input.GetKeyDown(stopPointerButton))
            {
                stopPointer = true;
            }

            currHeight = pointer.transform.position.y + dir * Time.deltaTime;
            pointer.transform.position = new Vector3(pointer.transform.position.x, currHeight, -2);
        }
        else
        {
            if (pointer.transform.position.y > winChanceBlock.transform.position.y - winChanceBlock.transform.lossyScale.y / 2 && pointer.transform.position.y < winChanceBlock.transform.position.y + winChanceBlock.transform.lossyScale.y / 2)
            {
                if (isDrawer)
                {
                    //reverse direction
                }
                else
                {
                    parent.GetComponent<DoorCollision>().OpenSuccesfull();
                    Destroy(gameObject);
                }
                Debug.Log("open");
            }
            else
            {
                Debug.Log("InDanger");
            }
        }


    }
    public void SpawnParent(GameObject spawnparent)
    {
        parent = spawnparent;
    }
}
