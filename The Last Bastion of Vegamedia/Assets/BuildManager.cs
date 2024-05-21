using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("M�s de un BuildManager en la escena!");
        }
        instance = this;
    }

    public GameObject standardCannonPrefab;

    private void Start()
    {
        cannonToBuild = standardCannonPrefab;
    }

    private GameObject cannonToBuild;

    public GameObject GetCannonToBuild()
    {
        return cannonToBuild;
    }
}
