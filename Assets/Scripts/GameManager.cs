using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(SpriteRenderer))]
public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnpoints;
    public SpriteRenderer spriteRenderer;
    public Color [] enemyColors;
    private float timeRemaining;
    public float spawnDelay;

    public TextMeshPro timerText;
    private Timer timer;
    
 


    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Timer>();
        timeRemaining = spawnDelay;
        InvokeRepeating("spawnenemy", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();
        }
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
          
            timeRemaining = spawnDelay;
        }
      
    }


    public void reloadscene()
    {
        SceneManager.LoadScene(0);
    }

    void spawnenemy()
    {
        int index = Random.Range(0, spawnpoints.Length);
        Vector3 spawnPos = spawnpoints[index].position;
        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        int dirModifier = 0;
        if (index > 2)
        {
            dirModifier = -1;
        }
        else
        {
            dirModifier = 1;
        }
        float newSpeed = Random.Range(3.0f, 6.9f);

        enemy.GetComponent<enemymovement>().speed = newSpeed * dirModifier;
        Color c = Color.black;
        if (newSpeed < 4.0f)
        {
            c = enemyColors[0];
        }
        else if (newSpeed >= 4.0f && newSpeed < 5.0f)
        {
            c = enemyColors[1];
        }
        else if (newSpeed >= 5.0f && newSpeed < 6.0f)
        {
            c = enemyColors[2];
        }
        else
        {
            c = enemyColors[3];
        }
        enemy.GetComponent<SpriteRenderer>().color = c;
    }
}
