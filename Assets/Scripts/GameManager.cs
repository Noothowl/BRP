using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float time;
    UIManager uiM;

    // Start is called before the first frame update
    void Start()
    {
        uiM = GetComponent<UIManager>();
        time = 1;
        Timer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Timer()
    {
        uiM.UpdateTimeUI(time);

        if (time > 0)
        {
            time++;
            Invoke("Timer", 1f);
        }
    }
}
