using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 10f;
    public float damage = 50f;
    private Transform target;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            Explode();
        }
    }

    void Explode()
    {

        // Zoek de Health component van het doel
        Health targetHealth = target.GetComponent<Health>();
        
        // Als de Health component aanwezig is, breng schade toe
        if (targetHealth != null)
        {
            targetHealth.TakeDamage(damage);
        }


        

        // Zoek Health component van target met GetComponent
        // Als Health script gevonden is, gebruik TakeDamage functie
        // Gebruik damage variable
        // Instantiate eventuele effecten
        
        Destroy(gameObject);
    }
}