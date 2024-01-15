using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float movementSpeed = Random.Range(1f, 5f);
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        
    }
    
    void OnCollisionEnter2D(Collision2D asteroid)
    {
        if (asteroid.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    
    
}

