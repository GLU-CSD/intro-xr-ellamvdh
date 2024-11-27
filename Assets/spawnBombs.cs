using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
    

public class spawnBombs : MonoBehaviour
{


    public GameObject Bombs;
    public Transform BombsTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }





    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Can I spawn one plz?");
        Instantiate(Bombs, BombsTransform.position, BombsTransform.rotation);
    }
}
