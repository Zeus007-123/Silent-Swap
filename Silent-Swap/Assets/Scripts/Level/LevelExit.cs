using UnityEngine;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<LevelUI>().ShowLevelComplete();
            SoundManager.Instance.Play(Sounds.Win);
        }
    }
}
