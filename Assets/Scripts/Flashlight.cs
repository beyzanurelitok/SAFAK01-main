using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject flashlight1;
    private bool light1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tKey.wasReleasedThisFrame)
        {
            light1 = !light1;
            flashlight1.SetActive(light1);
        }
    }
}
