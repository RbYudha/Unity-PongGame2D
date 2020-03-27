using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed = 20;

    public int ballDelay = 2;

    public Rigidbody2D ballObj;

    void Start()
    {
        ballObj.velocity = new Vector2(1, -1) * speed;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "WallRight" || collision.collider.name == "WallLeft") {
            StartCoroutine(ballRespawn());
            GetComponent<Transform>().position = new Vector2 (0, 0);
        }
    }

    public IEnumerator ballRespawn()
     {
         yield return new WaitForSeconds(ballDelay);
     }

}