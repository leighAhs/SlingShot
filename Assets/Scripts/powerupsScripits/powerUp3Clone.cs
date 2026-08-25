using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class powerUp3Clone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 5 * Time.deltaTime);

        if(transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            Destroy(gameObject);
        }
    }
}
