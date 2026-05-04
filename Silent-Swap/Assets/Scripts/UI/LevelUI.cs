using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUI : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject levelCompletePanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        levelCompletePanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        SoundManager.Instance.Play(Sounds.Detect);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Main Menu");
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
        int next = SceneManager.GetActiveScene().buildIndex + 1;

        if (next < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(next);
    }

    public void ShowLevelComplete()
    {
        levelCompletePanel.SetActive(true);
        Time.timeScale = 0f;
    }
}