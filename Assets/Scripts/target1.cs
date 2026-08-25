using Unity.VisualScripting;
using UnityEngine;

public class target1 : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] levelCounter level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("LevelCounter");
        level = obj.GetComponent<levelCounter>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            level.levelCount = level.levelCount + 1;
            Destroy(gameObject, 1f);
        }
    }
}
