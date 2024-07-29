using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnRate = 0.5f;
    private float nextDog = 0.0f;
  
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog )
        {
            nextDog = Time.time + dogSpawnRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
           


        }
    }

    
}
