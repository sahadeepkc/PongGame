using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public GameObject helpPanel;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        helpPanel.SetActive(isPaused);
    }

    public void OnScoreZoneReached(int id)
    {
        if (id == 1)
            scorePlayer1++;
        if (id == 2)
            scorePlayer2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreTextLeft.SetScore(scorePlayer1);
        scoreTextRight.SetScore(scorePlayer2);
    }
}