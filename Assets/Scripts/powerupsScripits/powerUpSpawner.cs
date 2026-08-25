using System.Collections;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] powerUps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnPowerUps());
    }

    IEnumerator spawnPowerUps()
    {
        while (true)
        {
            float randomXPos = Random.Range(-8.861886f, 8.861886f);
            float Ypos = 5.065036f;
            Vector2 randomPos = new Vector2(randomXPos, Ypos);

            int randomPowerup = Random.Range(0, 3);
            yield return new WaitForSeconds(5f);
            Instantiate(powerUps[randomPowerup], randomPos, transform.rotation);
        }
    }
}
