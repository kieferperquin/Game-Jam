using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] bool startFollowing;
    void FixedUpdate()
    {
        if (startFollowing)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
    public void Follow()
    {
        startFollowing = true;
    }
    public void StopFollow()
    {
        startFollowing = true;
    }
}
