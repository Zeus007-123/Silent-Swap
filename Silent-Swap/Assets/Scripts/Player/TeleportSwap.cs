using UnityEngine;
using System.Collections;

public class TeleportSwap : MonoBehaviour
{
    [SerializeField] private float swapRange = 10f;
    [SerializeField] private float cooldown = 3f;

    private float lastSwapTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastSwapTime + cooldown) 
        {
            GameObject nearestEnemy = FindNearestEnemy();

            if (nearestEnemy != null) 
            {
                Vector3 playerPos = transform.position;
                Vector3 enemyPos = nearestEnemy.transform.position;

                // Fix Y position so player doesn't float
                enemyPos.y = playerPos.y;

                // Swap positions
                transform.position = enemyPos;
                nearestEnemy.transform.position = playerPos;

                // Visual feedback
                StartCoroutine(Flash());

                lastSwapTime = Time.time;
            }
            Debug.Log("Swapped!");
        }
    }

    private GameObject FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject nearest = null;
        float minDist = swapRange;

        foreach (GameObject enemy in enemies)
        {
            float dist = Vector3.Distance(transform.position, enemy.transform.position);

            if (dist < minDist)
            {
                minDist = dist;
                nearest = enemy;
            }
        }

        return nearest;
    }

    // Small flash effect
    IEnumerator Flash()
    {
        Renderer r = GetComponent<Renderer>();

        if (r == null) yield break;

        Color original = r.material.color;

        r.material.color = Color.white;
        yield return new WaitForSeconds(0.2f);

        r.material.color = original;
    }
}
