using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreCalculator : MonoBehaviour
{
    public int ScoreVar = 0; // Public variable to hold the score.
    public TMP_Text scoreText; // Reference to the Text component in the UI.

    public string levelTextObjectName = "Level";

    public void Start(){
        scoreText = GameObject.Find(levelTextObjectName).GetComponent<TMP_Text>();
    }

    public void IncrementScoreText()
    {
        // Update the text in the UI element to display the score.
        ScoreVar++;
        scoreText.text = "Score: " + ScoreVar;
    }
}

