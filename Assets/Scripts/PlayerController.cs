using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xRange=16;
    public float topbound = 30;
    private float Horizontal;
    public GameObject projectileprefab;
    
    void Update()
    {
        if (transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x>xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        Horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*Horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileprefab,transform.position,projectileprefab.transform.rotation);
        }

        
        
        
    }
}
