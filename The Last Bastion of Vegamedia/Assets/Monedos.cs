using UnityEngine;
using UnityEngine.UI;

public class Monedos : MonoBehaviour
{
    public static int monedas = 15;
    public Text textComponent;

    void Start()
    {
        monedas = 15;

        if (textComponent == null)
        {
            textComponent = GetComponent<Text>();
        }
        UpdateTextValue();
    }

    void Update()
    {
        UpdateTextValue();
    }

    void UpdateTextValue()
    {
        textComponent.text = monedas.ToString();
    }

    public static void SpendMonedas(int amount)
    {
        monedas -= amount;
    }

    public static void AddMonedas(int amount)
    {
        monedas += amount;
    }
}
