using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score; 

    public Text score_text;

    public void add_score(int score_addition)     //we make a variable inside the function so when we activate the function we can adjust the varisble ex: add_score(3)
    {
        score = score + score_addition;

        score_text.text = "Score:" + score.ToString();  // we cant make string to int so we add ToString to make it string
    }

}
