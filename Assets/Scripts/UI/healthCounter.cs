using TMPro;
using UnityEngine;

public class healthCounter : MonoBehaviour
{
    [SerializeField] GameObject gameObj;
    [SerializeField] projectileSpawner script;
    TextMeshProUGUI healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        gameObj = GameObject.Find("projectileSpawner");
        script = gameObj.GetComponent<projectileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = script.playerHealth.ToString();
    }
}
