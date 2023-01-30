using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDanger : MonoBehaviour
{
    [SerializeField] KeyCode rapidPressButton;
    [SerializeField] float StartTime = 10;
    [SerializeField] int maxPresses = 20;
    int pressCount;
    int pressGoal;
    float timeLeft;
    bool inDanger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inDanger == true)
        {
            if (Input.GetKeyDown(rapidPressButton))
            {
                pressCount++;
            }

            if (pressCount >= pressGoal)
            {
                Debug.Log("hi");
            }
        }
    }
    void inDangerStart()
    {
        this.inDanger = true;
        pressCount = 0;
        timeLeft = StartTime;
    }
}
