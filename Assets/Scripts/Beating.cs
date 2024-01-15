using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
  
{
    [SerializeField ] private float scale = 2f;
    [SerializeField] private float rate = 0.5f;
    [SerializeField] private float timer = 0; 

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // Calculate the new scale factor based on a sine wave 
        float scaleFactor = Mathf.Abs(Mathf.Sin(timer * rate)) * scale; 
        transform.localScale = new Vector3(scaleFactor, scaleFactor,0);
       
    }
}
