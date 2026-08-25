using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class powerUp3 : MonoBehaviour
{
    [SerializeField] GameObject obj;
    GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("target");
    }

    private void OnMouseDown()
    {
        Vector2 position = new Vector2(-6.9f, 0.38f);
        Vector3 direction = target.transform.position;

        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
        Instantiate(obj, position, rotation);
        Destroy(gameObject);
    }
}
