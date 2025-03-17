using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimManager : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            animator.SetBool("Jump",true);
        }
    }
}
