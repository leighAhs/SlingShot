using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class projectileSpawner : MonoBehaviour
{

    [SerializeField] public int playerHealth = 5;

    [SerializeField] GameObject[] projectile;
    [SerializeField] float positionX;
    [SerializeField] float positionY;
    bool isReady = true;
    GameObject currentProjectile;

    [SerializeField] public int projectileCount;
    int currentIndex = 0;

    private void Start()
    {
        projectileCount = projectile.Length;
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
            projectileCount--;
            playerHealth = playerHealth - 1;
            isReady = true;
        }

        if(playerHealth <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
