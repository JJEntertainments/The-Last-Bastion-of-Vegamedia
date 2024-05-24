using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Monedos : MonoBehaviour
{
    public static int monedas = 15;
    public Text textComponent;

    TMP_TextElement_Legacy monedosText;
    void Start()
    {
        monedas = 15;

        if (textComponent == null)
        {
            textComponent = GetComponent<Text>();
        }
        UpdateTextValue();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTextValue();
    }


    void UpdateTextValue()
    {
        textComponent.text = monedas.ToString();
    }
}
