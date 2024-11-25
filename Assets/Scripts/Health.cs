using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Dit is nodig om Image te gebruiken


public class Health : MonoBehaviour
{
    public float maxHealth = 100f; // stelt max health in
    public float currentHealth; //huidige waarde van health bijhoudt
    public Image healthbarFill; //reference naar de image van de healthbar

    public GameObject Bob;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHeathBar();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <=0 ){
            Bob.SetActive(false);
        }
    }

    void UpdateHeathBar(){
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }
    public void TakeDamage(float amount){
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHeathBar();
    }

    public void RestoreHealth(float amount){
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHeathBar();
    }

}


