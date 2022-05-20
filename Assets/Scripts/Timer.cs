using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float gameDurationSeconds = 300;
    private float TimeRemaining;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = gameDurationSeconds;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (TimeRemaining > 1)
            {
                TimeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out");
                GetComponent<GameManager>().reloadscene();
                TimeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    public string GetTimeForDisplay()
    {
        float minutes = Mathf.FloorToInt(TimeRemaining / 60);
        float seconds = Mathf.FloorToInt(TimeRemaining % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
