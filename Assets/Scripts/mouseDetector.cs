using UnityEngine;

public class mouseDetector : MonoBehaviour
{
    [SerializeField] Vector2 currentMousePosition;

    Vector2 startingPoint;
    Vector2 direction;

    Rigidbody2D rb2d;

    [SerializeField] float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPoint = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        startingPoint = transform.position;
    }

    private void OnMouseDrag()
    {
        if(Vector2.Distance(currentMousePosition, startingPoint) < 3)
        {
            transform.position = currentMousePosition;
        }
    }

    private void OnMouseUp()
    {
        rb2d.gravityScale = 1;
        direction = startingPoint - currentMousePosition;
        rb2d.linearVelocity = direction * force;
        Invoke("resetPosition", 3f);
    }

    void resetPosition()
    {
        rb2d.gravityScale = 0;
        transform.position = startingPoint;
        rb2d.linearVelocity = Vector2.zero;
    }
}
