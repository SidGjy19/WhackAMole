using UnityEngine;
using TMPro;

public class HighscoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public GameObject highscorePanel;

    void OnEnable()
    {
        GameManager.Instance.onScoreChanged.AddListener(UpdateScore);
    }

    void OnDisable()
    {
        GameManager.Instance.onScoreChanged.RemoveListener(UpdateScore);
    }

    void UpdateScore(int newScore)
    {
        if (scoreText) scoreText.text = "Score: " + newScore;
        if (highscoreText) highscoreText.text = "Best: " + GameManager.Instance.highScore;
    }

    // Call this from VR controller button binding
    public void ToggleHighscorePanel()
    {
        highscorePanel.SetActive(!highscorePanel.activeSelf);
    }
}