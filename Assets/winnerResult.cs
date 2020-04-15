using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class winnerResult : MonoBehaviour
{
    public TextMeshProUGUI winnertext;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoreCounter.score1 > ScoreCounter.score2) {
            winnertext.text = "Player 1 wins";
        }
        else if (ScoreCounter.score1 < ScoreCounter.score2)
        {
             winnertext.text = "Player 2 wins";
        }
        else
        {
            winnertext.text = "Draw";
        }
    }

}
