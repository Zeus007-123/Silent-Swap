using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

            if (nextScene < SceneManager.sceneCountInBuildSettings) 
            {
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
