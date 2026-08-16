using UnityEngine;

public class normalProjectile : MonoBehaviour
{
    [SerializeField] Vector2 currentMousePosition;
    Vector2 startingPoint;
    Vector2 currentPosition;

    [SerializeField] Vector2 direction;
    [SerializeField] float speed;
    bool isTrue = false;
    private void Start()
    {
        startingPoint = transform.position;
        
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(direction * Time.deltaTime * speed);
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (isTrue) transform.Translate(direction * Time.deltaTime * speed);
    }

    private void OnMouseDrag()
    {
        if (!isTrue)
        {
            transform.position = currentMousePosition;
        }
    }
        

    private void OnMouseUp()
    {
        isTrue = true;
    }
}
