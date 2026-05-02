using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float speed = 3f;

    private int index = 0;

    private void Update()
    {
        if (points.Length == 0) return;

        Transform target = points[index];

        transform.position = Vector3.MoveTowards(transform.position, 
            target.position, 
            speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            index = (index + 1) % points.Length;
        }
    }
}
