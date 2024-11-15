using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class HealthUI : MonoBehaviour
{

    public string prefabTag = "Enemy";
    private Health healthScript;

    void Update(){
        if(healthScript == null){
            GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
            if(spawnedPrefab != null){
                healthScript = spawnedPrefab.GetComponent<Health>();
            }
        }

        
    }
    public void DamageButton(){
        if(healthScript != null){
            healthScript.TakeDamage(10);
        }
    }

    public void HealButton(){
        if(healthScript != null){
            healthScript.RestoreHealth(10);
        }
    }
    
}