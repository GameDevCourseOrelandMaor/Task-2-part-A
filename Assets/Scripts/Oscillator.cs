using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{    
    private bool directionFlag = true; // Direction flag
    private float startingPosition; // The initial x position of the object

    [SerializeField] private float mag = 4f; // The maximum distance from the starting point
    [SerializeField] private float speed = 2f; 
   
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position.x;  
        // Set the starting position to the current x position
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new x position based on a sine wave
        float rawSinWave = startingPosition + mag * Mathf.Sin(Time.time * speed);
        // Apply the new x position while keeping y and z the same
        transform.position = new Vector3(rawSinWave, transform.position.y, transform.position.z);
        // Determine the rotation direction based on the moving direction
        float rotationDirection = directionFlag? 1f : -1f;
        // Apply rotation around the z-axis
        transform.Rotate(new Vector3(0, 0, rotationDirection * speed * Time.deltaTime));
        // If the object has reached the maximum distance from the starting point, change the direction
        if ((directionFlag && rawSinWave >= startingPosition + mag) || (!directionFlag && rawSinWave <= startingPosition - mag))
        {
            directionFlag= !directionFlag;
        }
    }
}
