using UnityEngine;

public class powerup2 : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    [SerializeField] Vector2 spawnerPosition = new Vector2(0, 5.5f);

    private void OnMouseDown()
    {
        Instantiate(spawner, spawnerPosition, transform.rotation);
        Destroy(gameObject);
    }
}
