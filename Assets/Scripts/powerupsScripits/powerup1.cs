using UnityEngine;

public class powerup1 : MonoBehaviour
{
    [SerializeField] GameObject gameObj;
    [SerializeField] projectileSpawner script;

    private void Start()
    {
        gameObj = GameObject.Find("projectileSpawner");
        script = gameObj.GetComponent<projectileSpawner>();
    }
    private void OnMouseDown()
    {
        script.playerHealth++;
        Destroy(gameObject);
    }
}
