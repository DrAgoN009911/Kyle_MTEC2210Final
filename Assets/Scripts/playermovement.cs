using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5.0f;
    public GameManager gameManager;
    public projectilebehavior ProjectilePrefab;
    public Transform LaunchOffset;

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float xMovement = xMove * speed * Time.deltaTime;
        
        transform.Translate(xMovement, 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

  
   
}
