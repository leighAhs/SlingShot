using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class projectileSpawner : MonoBehaviour
{

    [SerializeField] int playerHealth = 5;

    [SerializeField] GameObject[] projectile;
    [SerializeField] float positionX;
    [SerializeField] float positionY;
    bool isReady = true;
    [SerializeField] List<GameObject> projectileList;
    GameObject currentProjectile;

    int currentIndex = 0;

    private void Start()
    {
        for (int i = 0; i < projectile.Length; i++)
        {
            GameObject obj = Instantiate(projectile[i], transform.position, transform.rotation);

            projectileList.Add(obj);
        }
    }
    void Update()
    {
        Vector2 startingPosition = new Vector2(positionX, positionY);

        for (int i = currentIndex; i < projectile.Length; i++)
        {
            if (isReady && projectile[i] != null)
            {
                isReady = false;

                currentProjectile = Instantiate(projectile[i], startingPosition, transform.rotation);

                currentIndex++;
                break;
            }
        }

        if (!isReady && currentProjectile == null)
        {
            playerHealth = playerHealth - 1;
            isReady = true;
        }

        if(playerHealth <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
