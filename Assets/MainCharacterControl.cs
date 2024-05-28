using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterControl : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;
    public float speed = 5.0f;
    public float vertical;
    public float horizontal;
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("vertical", vertical);
        animator.SetFloat("horizontal", horizontal);
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
