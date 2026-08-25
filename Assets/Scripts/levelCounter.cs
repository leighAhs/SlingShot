using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCounter : MonoBehaviour
{
    [SerializeField] public int levelCount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(levelCount == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
