using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public static int level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void loadSceneLevel()
    {
        if(level == 1)
        {
            SceneManager.LoadScene("Level1");
        } else if(level == 2)
        {
            SceneManager.LoadScene("Level2");
        } else if( level == 3)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
