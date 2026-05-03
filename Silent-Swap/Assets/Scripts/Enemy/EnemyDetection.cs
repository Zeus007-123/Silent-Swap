using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField] private float detectionRange = 5f;
    [SerializeField] private float fieldOfView = 90f;

    public LayerMask obstacleMask;

    private Transform player;

    private bool detected = false; // prevents multiple triggers

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 directionToPlayer = (player.position - transform.position).normalized;

        Debug.DrawRay(transform.position, directionToPlayer * detectionRange, Color.yellow);

        if (detected) return; // stop checking after detection

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < detectionRange) 
        {
            float angle = Vector3.Angle(transform.forward, directionToPlayer);

            if (angle < fieldOfView / 2f)
            {
                // Raycast check (line of sight)
                if (!Physics.Raycast(transform.position, directionToPlayer, distance, obstacleMask)) 
                {
                    //Player detected
                    Invoke(nameof(TriggerGameOver), 0.2f);
                }
            }
        }
    }

    private void TriggerGameOver()
    {
        FindObjectOfType<LevelUI>().ShowGameOver();
    }
}
