using UnityEngine;

public class hazard2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            Destroy(gameObject);
        }
    }
}
