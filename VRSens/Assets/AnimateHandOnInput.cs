using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty gripAnimation;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimation.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);
        Debug.Log(triggerValue);

        float gripValue = gripAnimation.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);
    }
}
