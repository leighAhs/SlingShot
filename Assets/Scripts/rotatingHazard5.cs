using UnityEngine;

public class rotatingHazard5 : MonoBehaviour
{
    [SerializeField] GameObject position;
    [SerializeField] Vector3 rotation;
    [SerializeField] float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = GameObject.Find("point");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position.transform.position;
        transform.eulerAngles += rotation * Time.deltaTime * rotationSpeed;
    }
}
