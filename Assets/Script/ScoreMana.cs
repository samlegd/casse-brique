using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreMana : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // Initialise le score au d�but du jeu
        UpdateScore();
    }

    void UpdateScore()
    {
        // Met � jour le texte du score
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddToScore(int points)
    {
        // Ajoute des points au score
        score += points;

        // Met � jour le texte du score
        UpdateScore();
    }
}