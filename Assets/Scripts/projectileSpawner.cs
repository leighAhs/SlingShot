using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class projectileSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;
    [SerializeField] float positionX;
    [SerializeField] float positionY;
    bool isReady = true;
    GameObject currentProjectile;

    int currentIndex = 0;

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
            isReady = true;
        }
    }
}
