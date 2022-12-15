using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : EnemyController
{
    Rigidbody mRBody;

    void Start()
    {
        mRBody = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (target != null)

        {
            if (currState == EnemyState.idle || currState == EnemyState.walk)
            {
                if (Vector3.Distance(transform.position, target.transform.position) < attackRadius)
                {
                    
                }
                else
                {
                    Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                    mRBody.MovePosition(temp);
                }                              
            }            
        }
    }
}
