using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Import the UnityEngine.UI namespace for Text component.

public class CalScore : MonoBehaviour
{
    ScoreCalculator scoreCalculator;
    //public TMP_Text levelText;
    /*public int ScoreVar; // Public variable to hold the score.
    public TMP_Text scoreText; // Reference to the Text component in the UI.

    public string levelTextObjectName = "Level";
    
    public void Start(){
        scoreText = GameObject.Find(levelTextObjectName).GetComponent<TMP_Text>();
        ScoreVar = 0;
    }*/
    
    public void Start(){
        //scoreCalculator = GetComponent<ScoreCalculator>();
        scoreCalculator = GameObject.Find("GameController").GetComponent<ScoreCalculator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) // Replace "SomeTag" with the tag of the object you want to collide with.
        {
            scoreCalculator.IncrementScoreText(); // Update the score in the UI.
        }
    }
}

