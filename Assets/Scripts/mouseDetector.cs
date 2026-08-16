using UnityEngine;
using System.Collections.Generic;

public class mouseDetector : MonoBehaviour
{
    [SerializeField] Vector2 currentMousePosition;

    Vector2 startingPoint;
    Vector2 currentPosition;
    Vector2 direction;

    Rigidbody2D rb2d;

    [SerializeField] float force;

    [SerializeField] GameObject dot;
    [SerializeField] List<GameObject> guideDots;
    [SerializeField] int guideLength;
    [SerializeField] float guideDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPoint = transform.position;
        rb2d = GetComponent<Rigidbody2D>();

        for (int i = 0; i < guideLength; i++)
        {
            GameObject obj = Instantiate(dot, transform.position, transform.rotation);
            guideDots.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPosition = transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, rb2d.linearVelocity);
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

            for (int i = 0; i < guideLength; i++)
            {
                guideDots[i].transform.position = guidePoint(guideDistance * i, startingPoint - currentMousePosition);
            }
        }
    }

    private void OnMouseUp()
    {
        rb2d.gravityScale = 1;
        direction = startingPoint - currentPosition;
        rb2d.linearVelocity = direction * force;
        Invoke("resetPosition", 3f);
    }

    void resetPosition()
    {
        rb2d.gravityScale = 0;
        transform.position = startingPoint;
        rb2d.linearVelocity = Vector2.zero;
    }

    Vector2 guidePoint(float timeInterval, Vector2 direction)
    {
        Vector2 dotPoint = currentMousePosition + (direction * force * timeInterval) + 0.5f * Physics2D.gravity * (timeInterval * timeInterval);
        return dotPoint;
    }
}
