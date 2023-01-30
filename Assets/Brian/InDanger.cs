using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDanger : MonoBehaviour
{
    [SerializeField] KeyCode rapidPressButton;
    [SerializeField] float StartTime = 5;
    [SerializeField] int maxPresses = 20;
    int pressCount = 0;
    int pressGoal = 5;
    float timeLeft;
    [SerializeField] bool inDanger = false;
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
                Debug.Log(pressCount);
            }

            if (pressCount >= pressGoal)
            {
                if (pressGoal > maxPresses)
                {
                    StartTime++;
                    Debug.Log(StartTime);
                }
                inDanger = false;
                pressCount = 0;
                pressGoal = pressGoal + 5;
            }
        }
    }
    void inDangerStart()
    {
        this.inDanger = true;
        timeLeft = StartTime;
    }
}
