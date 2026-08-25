using UnityEngine;

public class rotatingHazard : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    [SerializeField] float rotationSpeed;
    [SerializeField] int health = 3;
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += rotation * Time.deltaTime * rotationSpeed;

        if(health >= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            health = health - 1;
        }
    }
}
