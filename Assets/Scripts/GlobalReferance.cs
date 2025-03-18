using System;
using UnityEngine;

public class GlobalReferance : MonoBehaviour
{
    public static GlobalReferance Instance { get; set; }
    
    public GameObject bulletImpactEffectPrefab;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}
