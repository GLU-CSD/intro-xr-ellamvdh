using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    
    public float fireRate = 1f;


    public GameObject projectilePrefab;
    public Transform firePoint;

    public float nextFireTime = 0f;
    private List<Transform> enemiesInRange = new List<Transform>();




    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Enemy"))
    {
        enemiesInRange.Add(other.transform);
    }
}

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
        enemiesInRange.Remove(other.transform);
        }
    }


    Transform GetClosestEnemy(){
    Transform closestEnemy = null;
    float shortestDistance = Mathf.Infinity;

    foreach (Transform enemy in enemiesInRange)
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);
        if (distanceToEnemy < shortestDistance)
        {
            shortestDistance = distanceToEnemy;
            closestEnemy = enemy;
        }
    }
    return closestEnemy;
    }

    void Update()
{
    if (Time.time >= nextFireTime)
    {
        Transform target = GetClosestEnemy();
        if (target != null)
        {
            Shoot(target);
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}

void Shoot(Transform target)
{
    GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    projectile.GetComponent<Projectile>().SetTarget(target);
}








    





}
