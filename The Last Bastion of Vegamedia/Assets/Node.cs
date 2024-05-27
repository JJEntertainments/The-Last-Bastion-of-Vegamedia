using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject cannon;
    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (cannon != null)
        {
            if (cannon.GetComponent<Cannon>() != null && Monedos.monedas >= 30)
            {
                // Mejorar a CannonMejorado
                GameObject upgradedCannon = BuildManager.instance.GetUpgradedCannonToBuild();
                if (upgradedCannon != null)
                {
                    Destroy(cannon); // Destruir el cañón actual
                    cannon = (GameObject)Instantiate(upgradedCannon, transform.position + positionOffset, transform.rotation);
                    Monedos.SpendMonedas(30);
                    Debug.Log("Cañón mejorado a CannonMejorado");
                }
                return;
            }
            else
            {
                Debug.Log("No tienes suficientes monedas para mejorar el cañón o ya está mejorado!");
            }
            return;
        }

        if (Monedos.monedas < 15)
        {
            Debug.Log("No tienes suficientes monedas para construir un cañón!");
            return;
        }

        // Construcción del cañón
        GameObject cannonToBuild = BuildManager.instance.GetCannonToBuild();
        if (cannonToBuild != null)
        {
            cannon = (GameObject)Instantiate(cannonToBuild, transform.position + positionOffset, transform.rotation);
            Monedos.SpendMonedas(15);
            Debug.Log("Cañón construido");
        }
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
