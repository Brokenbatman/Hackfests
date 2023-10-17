using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0; // Current score
    public Text scoreText; // UI text element to display the score

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a ScoreSystem component
        ScoreSystem otherScoreSystem = collision.gameObject.GetComponent<ScoreSystem>();

        // If the other object has a ScoreSystem component, increase its score
        if (otherScoreSystem != null)
        {
            otherScoreSystem.IncreaseScore();
        }
    }

    public void IncreaseScore()
    {
        score++; // Increase the score by 1
        UpdateScoreText();
        Debug.Log($"{gameObject.name} received a point! Current score: {score}");
    }

    private void UpdateScoreText()
    {
        // Update the UI text element with the current score
        scoreText.text = "Score: " + score.ToString();
    }
}
