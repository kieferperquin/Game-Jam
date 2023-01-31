using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] bool startFollowing;
    [SerializeField] bool FollowX = true;
    [SerializeField] bool FollowY = false;
    void FixedUpdate()
    {
        if (startFollowing)
        {
            if (FollowX)
            {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            }
            if (FollowY)
            {
                transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            }
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
    public void SpecificFollow(bool folX, bool folY)
    {
        FollowX = folX;
        FollowY = folY;
    }
}
