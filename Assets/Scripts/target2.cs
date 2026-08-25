using UnityEngine;

public class target2 : MonoBehaviour
{
    bool switchDirection = true;
    [SerializeField] float speed;
    [SerializeField] float maxY;
    [SerializeField] float minY; 
    [SerializeField] GameObject obj;
    [SerializeField] levelCounter level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("LevelCounter");
        level = obj.GetComponent<levelCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < maxY && switchDirection)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (transform.position.y > minY && !switchDirection)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        } else
        {
            switchDirection = !switchDirection;
        }
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
