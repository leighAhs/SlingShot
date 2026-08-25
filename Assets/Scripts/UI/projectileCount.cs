using TMPro;
using UnityEngine;

public class projectileCount : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] projectileSpawner script;
    TextMeshProUGUI textMeshProUGUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        obj = GameObject.Find("projectileSpawner");
        script = obj.GetComponent<projectileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = script.projectileCount.ToString();
    }
}
