using UnityEngine;

public class mouseDetector : MonoBehaviour
{
    [SerializeField] Vector2 currentMousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
