using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCounter : MonoBehaviour
{
    [SerializeField] public int levelCount;
    [SerializeField] bool level1;
    [SerializeField] bool level2;
    [SerializeField] bool level3;

    // Update is called once per frame
    void Update()
    {
        if(level1 && levelCount == 2)
        {
            SceneManager.LoadScene("Level2");
            level1 = false;
        } 
        else if(level2 && levelCount == 3)
        {
            SceneManager.LoadScene("Level3");
            level2 = false;
        }


        if (level1)
        {
            retry.level = 1;
        } else if (level2)
        {
            retry.level = 2;
        } else if (level3)
        {
            retry.level = 3;
        }
    }
}
