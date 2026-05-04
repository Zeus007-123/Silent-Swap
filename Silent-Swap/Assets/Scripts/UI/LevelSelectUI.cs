using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectUI : MonoBehaviour
{
    public void LoadLevel1()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Level 3");
    }

    public void Back()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene("Main Menu");
    }
}