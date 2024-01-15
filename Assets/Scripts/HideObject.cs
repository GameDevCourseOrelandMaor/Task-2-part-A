using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HideObject : MonoBehaviour
{
    [SerializeField]InputAction show = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        show.Enable();
    }

    void OnDisable()
    {
        show.Disable();
    }

    // Update is called once per frame
    void Update()
    {
         if(show.WasPressedThisFrame())
          {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

            Debug.Log(gameObject.activeSelf);
         }
    }
}