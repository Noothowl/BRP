using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    idle,
    walk,
    attack
}

public class Player : MonoBehaviour
{
    [Header("StateMachine")]
    public PlayerState currentState;

    [Header("Stats")]
    public float hp;
    public float maxHp;
    public float speed;

    [Header("Unity things")]
    Rigidbody rb;
    Vector3 change;
    Animator ar;

    private void Start()
    {
        //ar = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.z = Input.GetAxisRaw("Vertical");

        if(currentState == PlayerState.walk || currentState == PlayerState.idle)
        {
            UpdateArAndMove();
        }
    }

    void UpdateArAndMove()
    {
        if (change != Vector3.zero)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        rb.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
