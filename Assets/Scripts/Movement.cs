using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 20f;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 vector2 = new Vector2(horizontalInput,verticalInput );
        transform.Translate(vector2 * speed * Time.deltaTime);
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), Mathf.Clamp(transform.position.y, -5f, 5f), 0);

        
    }
    
    void OnCollisionEnter2D(Collision2D asteroid)
    {
        if (asteroid.gameObject.CompareTag("Asteroid"))
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    
    
    
}
