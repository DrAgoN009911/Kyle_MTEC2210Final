using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public GameObject bullet;
    public GameObject muzzle;
    public float speed = 5.0f;
    public GameManager gameManager;
    

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float xMovement = xMove * speed * Time.deltaTime;
        
        transform.Translate(xMovement, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, muzzle.transform).GetComponent<Rigidbody2D>
                ().AddForce(muzzle.transform.position * -10, ForceMode2D.Impulse);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

  
   
}
