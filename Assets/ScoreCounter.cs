using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard1, scoreBoard2;
    public static int score1 = 0, score2 = 0;

    void Start()
    {
        scoreBoard1.text = score1.ToString();
        scoreBoard2.text = score2.ToString();
    }

    public void updateScore (string namaWall) {
        if (namaWall == "WallLeft") {
            score1 += 1;
            scoreBoard1.text = score1.ToString();
        }
        else if (namaWall == "WallRight") {
            score2 += 1;
            scoreBoard2.text = score2.ToString();
        }
    }

}
