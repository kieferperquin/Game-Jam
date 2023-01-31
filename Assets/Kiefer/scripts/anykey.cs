using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anykey : MonoBehaviour
{
    public GameObject start;
    void Update()
    {
        if (Input.anyKey)
        {
            start.GetComponent<GameStart>().StartGame();
        }
    }
}
