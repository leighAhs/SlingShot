using UnityEngine;

public class powerUp2Clone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Vector2.down * 4);

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
