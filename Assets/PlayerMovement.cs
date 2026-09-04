using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        // Do something here, e.g., play a sound, trigger an animation, or destroy an object
        
    }
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
