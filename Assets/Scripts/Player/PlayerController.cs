using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    idle,
    walk,
    attack
}

public class PlayerController: MonoBehaviour
{
    [Header("StateMachine")]
    public PlayerState currentState;

    [Header("Stats")]
    public float hp;
    public float maxHp;
    public float speed;

    public float startCooldown1;
    public float startCooldown2;
    public float startCooldown3;
    public float startCooldown4;
    public float cooldown1;
    public float cooldown2;
    public float cooldown3;
    public float cooldown4;

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
            UpdateRotation();
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

    void UpdateRotation()
    {
        Vector3 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        Vector3 direction = mouseOnScreen - positionOnScreen;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, -angle, 0);
    }
}
