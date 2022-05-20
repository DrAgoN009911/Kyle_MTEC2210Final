using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilebehavior : MonoBehaviour
{
    public float sceneradius = 15;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -sceneradius)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > sceneradius)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -sceneradius)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > sceneradius)
        {
            Destroy(gameObject);
        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }

}


