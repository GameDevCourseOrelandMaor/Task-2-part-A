using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float mag = 4f; // The maximum distance from the starting point
    [SerializeField] private float speed = 2f; // The speed of the oscillation
    private float xStart; // The initial x position of the object
    private bool isMovingRight = true; // Direction flag

    // Start is called before the first frame update
    void Start()
    {
        xStart = transform.position.x; // Capture the initial x position
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new x position based on a sine wave
        float xNew = xStart + mag * Mathf.Sin(Time.time * speed);
        // Apply the new x position while keeping y and z the same
        transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

        // Determine the rotation direction based on the moving direction
        float rotationDirection = isMovingRight ? 1f : -1f;
        // Apply rotation around the z-axis
        transform.Rotate(new Vector3(0, 0, rotationDirection * speed * Time.deltaTime));
    
        // Check if the object has reached the extent of its magnitude and reverse direction if so
        if ((isMovingRight && xNew >= xStart + mag) || (!isMovingRight && xNew <= xStart - mag))
        {
            isMovingRight = !isMovingRight;
        }
    }
}
