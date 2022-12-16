using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class EnemyController : MonoBehaviour
{
    [Header("State machine")]
    public EnemyState currState;

    [Header("Stats")]
    public float hp;
    public float maxHp;
    public float moveSpeed;
    public int level = 1;
    public Transform target;
    public float attackRadius;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
