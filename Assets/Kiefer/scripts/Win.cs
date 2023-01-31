using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject canvas;

    int amountDown = 0;

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (amountDown == 0)
            {
                canvas.GetComponent<GameStart>().menu();
            }
            else if(amountDown == 1)
            {
                canvas.GetComponent<Quit>().quit();
            }
            else
            {

            }
        }

        if (Input.GetKeyDown("W"))
        {
            if (amountDown == 0)
            {

            }
            else if (amountDown == 1)
            {
                amountDown = 0;
            }
        }

        if (Input.GetKeyDown("S"))
        {
            if (amountDown == 1)
            {

            }
            else if (amountDown == 0)
            {
                amountDown = 1;
            }
        }
    }
}
