using System.Collections;
using UnityEngine;

public class target3 : MonoBehaviour
{
    [SerializeField] Vector2 startingPos;
    [SerializeField] Vector2 targetPosition;
    [SerializeField] Vector3 rotation;
    [SerializeField] int rotateSpeed;
    [SerializeField] bool startPos;
    [SerializeField] bool changePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += rotation * rotateSpeed * Time.deltaTime;

        if (startPos) StartCoroutine(startingPosition());
        if (changePos) StartCoroutine(changePosition());
    }

    IEnumerator startingPosition()
    {
        transform.position = startingPos;
        yield return new WaitForSeconds(3f);

        startPos = false;
        changePos = true;
    }

    IEnumerator changePosition()
    {
        transform.position = targetPosition;
        yield return new WaitForSeconds(3f);

        changePos = false;
        startPos = true;
    }
}
