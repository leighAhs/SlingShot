using System.Collections;
using UnityEngine;

public class powerUp2Spawner : MonoBehaviour
{
    [SerializeField] GameObject obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        float firstPosX = Random.Range(-8.83f, 8.83f);

        Vector2 randomFisrtPos = new Vector2(firstPosX, 5.1f);
        Instantiate(obj, randomFisrtPos, transform.rotation);
        while (true)
        {
            float posX = Random.Range(-8.83f, 8.83f);

            Vector2 randomPos = new Vector2(posX, 5.1f);

            yield return new WaitForSeconds(2f);

            Instantiate(obj, randomPos, transform.rotation);
        }
    }
}
