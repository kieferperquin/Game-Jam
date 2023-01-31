using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDanger : MonoBehaviour
{
    [SerializeField] KeyCode rapidPressButton;
    [SerializeField] GameObject menuScreen;
    [SerializeField] GameObject rapidPressScreen;
    float StartTime = 5;
    int maxPresses = 50;
    int pressCount = 0;
    int pressGoal = 5;
    float timeLeft = 5;
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
            rapidPressScreen.SetActive(true);

            timeLeft = timeLeft - 1 * Time.deltaTime;
            if (timeLeft <= 0)
            {
                inDanger = false;
                YouLost();
            }
            if (Input.GetKeyDown(rapidPressButton))
            {
                pressCount++;
                Debug.Log(pressCount);
            }

            if (pressCount >= pressGoal)
            {
                if (pressGoal >= maxPresses)
                {
                    StartTime += 0.5f;
                    maxPresses += 5;
                    Debug.Log(StartTime);
                }
                inDanger = false;
                pressGoal += 5;
                gameObject.GetComponent<Movement>().ResumeMoving();
            }

            rapidPressScreen.GetComponentInChildren<>
        }
        else
        {
            rapidPressScreen.SetActive(false);
        }
    }
    public void InDangerStart()
    {
        this.inDanger = true;
        timeLeft = StartTime;
        pressCount = 0;
    }
    public void YouLost()
    {
        rapidPressScreen.SetActive(false);
        menuScreen.GetComponent<WinLose>().Lose();
    }
}
