using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void OnCollisionEnter(Collision collision)
    {
        // Controleer of de grenade het terrein raakt
        if (collision.gameObject.CompareTag("Terrain"))
        {
            Debug.Log("u threw it on the ground");
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
