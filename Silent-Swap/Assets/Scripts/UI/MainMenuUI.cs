using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject howToPlayPanel;

    public void Play()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Level Select");
    }

    public void ShowHowToPlay()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        howToPlayPanel.SetActive(true);
    }

    public void HideHowToPlay()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        howToPlayPanel.SetActive(false);
    }

    public void Quit()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        Application.Quit();
        Debug.Log("Quit"); // works in editor
    }
}