using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreBoard;
    public GameObject ball;

    //private int player1Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find ("Ball");
    }

    // void Update()
    // {
    //     if(ball.transform.position.x >= 27.5f){
    //         player1Score ++;
    //     }

    //     print(player1Score);
    // }

}
