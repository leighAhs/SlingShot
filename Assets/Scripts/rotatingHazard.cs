using UnityEngine;

public class rotatingHazard : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    [SerializeField] float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += rotation * Time.deltaTime * rotationSpeed;
    }
}
