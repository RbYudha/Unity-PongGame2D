using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update

    //public int speed = 20;

    public GameObject scoreCounter;

    public int ballDelay = 1;

    public Rigidbody2D ballObj;

    //public Animation fire;

    public Animator fireAnim;

    void Start()
    {
        int x = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int speed = Random.Range(20, 26); //nilai speed bisa bernilai 20 sampai 25

        ballObj.velocity = new Vector2(x, y) * speed;
        ballObj.GetComponent<Transform>().position = Vector2.zero;
        fireAnim.SetBool("ballMoving", true);
    }

    void FixedUpdate()
    {
        //ball move to the right
        if ( ballObj.velocity.x > 0 ) {
            ballObj.GetComponent<Transform>().localScale = new Vector3 (1,1,1);

        //ball move to the left
        } else {
            ballObj.GetComponent<Transform>().localScale = new Vector3 (-1,1,1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "WallRight" || collision.collider.name == "WallLeft") {
            scoreCounter.GetComponent<ScoreCounter>().updateScore(collision.collider.name);
            StartCoroutine(ballRespawn());
        }
    }

    public IEnumerator ballRespawn()
     {
         ballObj.velocity = Vector2.zero;
         fireAnim.SetBool("ballMoving", false);
         ballObj.GetComponent<Transform>().position = Vector2.zero;

         yield return new WaitForSeconds(ballDelay);

         int x = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
         int y = Random.Range(0, 2)*2 - 1; //nilai x bisa bernilai -1 atau 1
         int speed = Random.Range(20, 26); //nilai speed bisa bernilai 20 sampai 25

         ballObj.velocity = new Vector2(x, y) * speed;
         fireAnim.SetBool("ballMoving",true);
     }

}