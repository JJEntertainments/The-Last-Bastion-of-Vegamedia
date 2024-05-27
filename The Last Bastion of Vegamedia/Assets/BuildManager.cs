using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Más de un BuildManager en la escena!");
        }
        instance = this;
    }

    public GameObject standardCannonPrefab;
    public GameObject upgradedCannonPrefab;

    private GameObject cannonToBuild;

    private void Start()
    {
        cannonToBuild = standardCannonPrefab;
    }

    public GameObject GetCannonToBuild()
    {
        return cannonToBuild;
    }

    public GameObject GetUpgradedCannonToBuild()
    {
        return upgradedCannonPrefab;
    }
}
