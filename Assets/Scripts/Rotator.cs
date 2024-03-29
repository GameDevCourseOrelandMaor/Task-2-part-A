using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed = 40f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,1), speed * Time.deltaTime); // Rotate around the z-axis

    }
}
