using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText; // Reference to the UI Text component.
    public int[] topScores = new int[10]; // Array to store the top 10 scores.

    // Call this method to display the top scores on the screen.
    public void DisplayHighScores()
    {
        // Fetch and update the top scores (you need to implement this logic)
        FetchTopScores();

        // Create a string to display the scores
        string highScoreString = "Top 10 High Scores:\n";
        for (int i = 0; i < topScores.Length; i++)
        {
            highScoreString += (i + 1) + ". " + topScores[i] + "\n";
        }

        // Update the UI Text component with the high scores
        highScoreText.text = highScoreString;
    }

    // This is a placeholder method; you should implement your logic to fetch the top scores.
    private void FetchTopScores()
    {
        // Replace this with your actual logic to retrieve top scores from your game.
        // For this example, let's assume top scores are stored in a simple array.
        for (int i = 0; i < topScores.Length; i++)
        {
            topScores[i] = Random.Range(100, 1000); // Replace with actual score values.
        }

        // Sort the top scores in descending order (highest to lowest).
        System.Array.Sort(topScores);
        System.Array.Reverse(topScores);
    }
}
