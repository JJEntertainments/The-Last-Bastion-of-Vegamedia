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
        if(cannon != null)
        {
            Debug.Log("Ya hay puesto un cañón!");
            return;
        }

        // Construcción del cañón
        GameObject cannonToBuild = BuildManager.instance.GetCannonToBuild();
        cannon = (GameObject)Instantiate(cannonToBuild, transform.position + positionOffset, transform.rotation);

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
