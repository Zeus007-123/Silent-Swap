using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject howToPlayPanel;

    public void Play()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void ShowHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void HideHowToPlay()
    {
        howToPlayPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit"); // works in editor
    }
}