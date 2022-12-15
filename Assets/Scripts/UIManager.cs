using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timeText;

    public void UpdateTimeUI(float time)
    {
        int minutes = (int)(time / 60);
        float seconds = (int)(time % 60);

        timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
