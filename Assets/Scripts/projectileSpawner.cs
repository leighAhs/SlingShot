using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class projectileSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;

    bool isReady = true;
    GameObject currentProjectile;

    int currentIndex = 0;

    void Update()
    {
        float positionX = -6.401054f;
        float positionY = -1.503922f;

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
