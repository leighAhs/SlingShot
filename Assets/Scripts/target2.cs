using UnityEngine;

public class target2 : MonoBehaviour
{
    bool switchDirection = true;
    [SerializeField] float speed;
    [SerializeField] float maxY;
    [SerializeField] float minY;
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
}
