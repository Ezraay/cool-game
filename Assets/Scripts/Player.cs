using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    [SerializeField] private float movementSpeed = 5f;
    
    private new Rigidbody2D rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Gets the WASD or Arrow Keys input
        input.Normalize(); // Makes diagonal moving slower

        Vector2 velocity = input * movementSpeed;
        rigidbody.velocity = velocity;
    }
}
