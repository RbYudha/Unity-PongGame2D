using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed = 20;

    public int ballDelay = 1;

    public Rigidbody2D ballObj;

    //public Animation fire;

    public Animator fireAnim;

    void Start()
    {
        ballObj.velocity = new Vector2(1, -1) * speed;
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
            StartCoroutine(ballRespawn());
        }
    }

    public IEnumerator ballRespawn()
     {
         ballObj.velocity = Vector2.zero;
         fireAnim.SetBool("ballMoving", false);
         ballObj.GetComponent<Transform>().position = Vector2.zero;
         yield return new WaitForSeconds(ballDelay);
         ballObj.velocity = new Vector2(1, -1) * speed;
         fireAnim.SetBool("ballMoving",false);
     }

}