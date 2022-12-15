using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantis : PlayerController
{
    public float damage1;
    public bool buff = false;
    public float damage3;
    public float damage4;
    public int hit1 = 0;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject.FindGameObjectWithTag("Attack").GetComponent<Animator>().SetTrigger("AttackP");
            hit1++;
            if (hit1 == 4)
            {
                hit1 = 0;
            }
            if (buff == true)
            {
                if (hit1 == 3)
                {
                    buff = false;
                    damage1 -= 10;
                }
            }
        }

        if (cooldown2 <= 0)
        {
            if (Input.GetMouseButtonUp(1))
            {

                if (buff == false)
                {
                    buff = true;
                    damage1 += 10;
                    hit1 = 0;
                }
                else if (buff == true)
                {
                    Debug.Log("Already buff");
                }
                cooldown2 = startCooldown2;
            }
        }
        else
        {
            cooldown2 -= Time.deltaTime;
        }
    }
}
