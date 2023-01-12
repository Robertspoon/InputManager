using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptTest : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public PlayerInputActions playerControls;
    
    

    Vector3 moveDirection = Vector3.zero;
    private InputAction move;
    private InputAction fire;

    private void Awake()
    {
        playerControls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDirection.x * speed, moveDirection.z * speed);
    }
}
