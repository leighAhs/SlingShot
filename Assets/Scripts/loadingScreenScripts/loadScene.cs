using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void loadNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
