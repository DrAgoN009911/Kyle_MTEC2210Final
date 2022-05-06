using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemymovement : MonoBehaviour
{
    public float speed = 3;

    // Update is called once per frame
    void Update()
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0, yValue , 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BottomWall")

        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

