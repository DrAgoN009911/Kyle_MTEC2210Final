using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilebehavior : MonoBehaviour
{
    public float Speed = 4.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * Speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        Destroy(gameObject);
    }

}
