using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerP2 : MonoBehaviour
{
    public static ScoreManagerP2 instance;
    public int currentScore = 0;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Ensures only one instance exists
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreDisplay();
    }
    public void AddScore(int points)
    {
        currentScore += points;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }
}
