using UnityEngine;

public class hazard5 : MonoBehaviour
{
    [SerializeField] float speed;

    bool isTrue = true;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 5.46 && isTrue)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        } else if(transform.position.y > 2 && !isTrue)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            isTrue = !isTrue;
        }
    }
}
