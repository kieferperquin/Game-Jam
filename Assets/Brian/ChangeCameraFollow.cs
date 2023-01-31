using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraFollow : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject player;
    [SerializeField] bool followX;
    [SerializeField] bool followY;
    [SerializeField] bool followAll;
    public float startYvalue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == player.name)
        {
            if (followAll)
            {
                mainCamera.GetComponent<PlayerFollow>().Follow();
            }
            else
            {
                mainCamera.GetComponent<PlayerFollow>().StopFollow();
            }

            mainCamera.GetComponent<PlayerFollow>().SpecificFollow(followX, followY);
            if (startYvalue != 0)
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, startYvalue, mainCamera.transform.position.z);
            }
        }
    }
}
